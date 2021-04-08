<template>
  <b-container>
    <b-form @submit="onSubmit" v-if="show">
      <b-form-group
        id="first-name-group"
        label="First Name:"
        label-for="first-name"
      >
        <b-form-input
          id="first-name"
          v-model="mosqueBooking.firstName"
          type="text"
          placeholder="First Name"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group
        id="last-name-group"
        label="Last Name:"
        label-for="last-name"
      >
        <b-form-input
          id="last-name"
          v-model="mosqueBooking.lastName"
          type="text"
          placeholder="Last Name"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group
        id="phone-number-group"
        label="Phone Number:"
        label-for="phone-number"
      >
        <b-form-input
          id="phone-number"
          v-model="mosqueBooking.phoneNumber"
          type="text"
          placeholder="Phone Number"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group id="email-group" label="Email:" label-for="email">
        <b-form-input
          id="email"
          v-model="mosqueBooking.email"
          type="text"
          placeholder="Email"
          required
        ></b-form-input>
      </b-form-group>
      <b-row>
        <b-col md="6">
          <b-form-group id="datepicker" label="Date:" label-for="bookingDate">
            <b-form-datepicker
              id="bookingDate"
              class="mb-2"
              @input="onDateChange"
              v-model="mosqueBooking.date"
            ></b-form-datepicker>
          </b-form-group>
        </b-col>
        <b-col md="6">
          <b-form-group id="groups" label="Group:" label-for="selectGroup">
            <b-select
              id="selectGroup"
              text="Select a group"
              block
              variant="primary"
              :disabled="isDisabled"
              :options="mosqueBooking.dropdownGroups"
              v-model="selectedGroupId"
              @change="changeInAvailability()"
            >
            </b-select>
          </b-form-group>
        </b-col>
      </b-row>

      <b-row>
        <b-col md="6">
          <b-button type="submit" variant="dark">Book Now</b-button>
        </b-col>

        <b-col md="6">
          <b-alert
            :variant="availabilityStatus.variant"
            :show="availabilityIsShown"
          >
            {{ availabilityStatus.message }}
          </b-alert>
        </b-col>
      </b-row>
    </b-form>
  </b-container>
</template>

<script>
import api from "../shared/data.service";

export default {
  name: "Booking",
  data() {
    return {
      event: {},
      show: true,
      isDisabled: true,
      availabilityIsShown: false,
      selectedGroupId: null,
      availability: null,
      mosqueBooking: {
        firstName: "",
        lastName: "",
        phoneNumber: "",
        email: "",
        date: "",
        dropdownGroups: [],
      },
    };
  },
  computed: {
    availabilityStatus() {
      return this.availability == 0
        ? {
            variant: "danger",
            message: "There are no available places in this group",
          }
        : {
            variant: "success",
            message: `${this.availability} places are still available`,
          };
    },
  },
  methods: {
    onSubmit() {},
    onDateChange() {
      if (this.mosqueBooking.date) {
        this.isDisabled = false;
      }
      this.getGroupsByEvent();
    },
    changeInAvailability() {
      if (this.selectedGroupId == null) {
        return;
      }
      var selectedGroup = this.event.groups.find(
        (element) => element.id == this.selectedGroupId
      );
      this.availabilityIsShown = true;
      this.availability = selectedGroup.availability;
    },
    getGroupsByEvent() {
      api.fetch("events/" + this.$route.params.eventId, (response) => {
        console.log(response);
        this.event = response.data;
        this.event.groups.forEach((element) => {
          this.mosqueBooking.dropdownGroups.push({
            text: element.name,
            value: element.id,
          });
        });
      });
    },
  },
};
</script>

<style lang="scss" scoped>
</style>