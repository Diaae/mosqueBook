<template>
  <b-container>
    <b-form @submit="onSubmit" v-if="show">
      <!-- Date -->
      <b-row>
        <b-col md="6">
          <b-form-group id="datepicker" label="Date:" label-for="bookingDate">
            <b-form-datepicker
              id="bookingDate"
              class="mb-2"
              @input="onDateChange()"
              v-model="appointment.date"
              variant="Warning"
            ></b-form-datepicker>
          </b-form-group>
        </b-col>
        <!-- Groups -->
        <b-col md="6">
          <b-form-group id="groups" label="Group:" label-for="selectGroup">
            <b-select
              id="selectGroup"
              text="Select a group"
              block
              variant="primary"
              :disabled="isDisabled"
              :options="dropdownGroups"
              v-model="selectedGroupId"
              @change="changeInAvailability()"
            >
            </b-select>
          </b-form-group>
        </b-col>
      </b-row>
      <!-- Availability -->
      <b-row>
        <b-col md="6">
          <b-alert
            :variant="availabilityStatus.variant"
            :show="availabilityIsShown"
          >
            {{ availabilityStatus.message }}
          </b-alert>
        </b-col>
      </b-row>

      <b-form-group
        id="first-name-group"
        label="First Name:"
        label-for="first-name"
      >
        <b-form-input
          id="first-name"
          v-model="appointment.user.firstName"
          type="text"
          placeholder="First Name"
          :disabled="isDisabled"
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
          v-model="appointment.user.lastName"
          type="text"
          placeholder="Last Name"
          :disabled="isDisabled"
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
          v-model="appointment.user.phoneNumber"
          type="text"
          placeholder="Phone Number"
          :disabled="isDisabled"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group id="email-group" label="Email:" label-for="email">
        <b-form-input
          id="email"
          v-model="appointment.user.email"
          type="text"
          placeholder="Email"
          :disabled="isDisabled"
        ></b-form-input>
      </b-form-group>

      <b-button variant="dark" :disabled="isDisabled" type="submit">
        Book Now</b-button
      >
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
      appointment: {
        date: "",
        selectedGroup: {},
        user: {
          firstName: "",
          lastName: "",
          phoneNumber: "",
          email: "",
        },
      },
      dropdownGroups: [],
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
      this.availabilityIsShown = false;
      if (this.appointment.date) {
        this.isDisabled = false;
      }
      this.getGroupsByEvent();
    },
    changeInAvailability() {
      if (this.selectedGroupId == null) {
        return;
      }
      this.appointment.selectedGroup = this.event.groups.find(
        (element) => element.id == this.selectedGroupId
      );
      this.availabilityIsShown = true;
      this.availability = this.appointment.selectedGroup.availability;
    },
    getGroupsByEvent() {
      api.fetch("events/" + this.$route.params.eventId, (response) => {
        console.log(response);
        this.event = response.data;
        if(!this.event.length){
          alert("NOTHIING");
        }
        this.dropdownGroups = [
          { value: null, text: "Please select a group" },
        ];
        this.event.groups.forEach((element) => {
          this.dropdownGroups.push({
            text: element.name,
            value: element.id,
          });
        });
      });
    },
    dateToast(variant = null) {
      this.$bvToast.toast('There is no event in this date, please select another date', {
      title: `${variant}`,
      variant: variant,
      solid: true
      });
    },
  },
};
</script>

<style lang="scss" scoped>
</style>