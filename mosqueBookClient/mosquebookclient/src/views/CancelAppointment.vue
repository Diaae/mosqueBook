<template>
  <b-container>
    <b-row>
      <b-col md="6" class="my-1">
        <b-form-group label-cols-sm="3" label="Phone Number:" class="mb-50">
          <b-input-group>
            <b-form-input
              v-model="bToken"
              placeholder="Please enter your phone number here"
            ></b-form-input>
            <b-input-group-append>
              <b-button @click="search" variant="dark">Ok</b-button>
            </b-input-group-append>
          </b-input-group>
        </b-form-group>
      </b-col>
    </b-row>

    <b-form @submit="onCancel" v-if="show">
      <!-- Date -->
      <b-row>
        <b-col md="6">
          <b-form-group id="datepicker" label="Date:" label-for="bookingDate">
            <b-form-datepicker
              id="bookingDate"
              class="mb-2"
              v-model="appointment.date"
              :disabled="isDisabled"
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
            >
            </b-select>
          </b-form-group>
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

      <b-button
        type="submit"
        variant="danger"
        @click="onCancel()"
      >
        Cancel Booking</b-button
      >
    </b-form>

    <div>
      <b-modal id="cancelConfirmation" hide-footer>
        <template #modal-title> Confirmation </template>
            <div class="d-block text-center">
                <h3>Are you sure you want to delete this booking?</h3>
             </div>
        <b-button
          class="mt-3"
          block
          @click="()=>cancelAppointment()"
          variant="danger">
            Yes
          </b-button>
      </b-modal>
    </div>
  </b-container>
</template>

<script>
import api from "../shared/data.service";
export default {
  name: "Booking",
  data() {
    return {
      event: {},
      show: false,
      isDisabled: true,
      selectedGroupId: null,
      bToken: null,
      appointment: {
        id:"",
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

  methods: {
    onCancel() {
      this.$bvModal.show('cancelConfirmation');
    },
    cancelAppointment(){
      api.delete("appointment/"+this.appointment.id,(response)=>{
        if(response.status === 200){
          alert("success");
        }
      },
      (error)=>{
        console.log(error);
      });
    },
    search(){

    },
    finalRedirection(){
        this.$router.push({
            name: "Events"
        })
    },

    getGroupsByEvent() {
      api.fetch("events/" + this.$route.params.eventId, (response) => {
        console.log(response);
        this.event = response.data;

        this.event.groups.forEach((element) => {
          this.dropdownGroups.push({
            text: element.name,
            value: element.id,
          });
        });
      });
    },
  },
  // Your booking was cancelled successfully
};
</script>

<style lang="scss" scoped>
</style>