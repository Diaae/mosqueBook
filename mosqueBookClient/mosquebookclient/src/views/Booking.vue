<template>
  <b-container>
    <b-form v-if="show">
      <!-- Date -->
      <b-row>
        <b-col md="6">
          <b-form-group id="datepicker" label="Datum:" label-for="bookingDate">
            <b-form-datepicker
              id="bookingDate"
              class="mb-2"
              @input="onDateChange()"
              v-model="appointment.date"
              placeholder="Wann?"
              :min="minDate"
            ></b-form-datepicker>
          </b-form-group>
        </b-col>
        <!-- Groups -->
        <b-col md="6">
          <b-form-group id="groups" label="Gruppen:" label-for="selectGroup">
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
        label="Vorname:"
        label-for="first-name"
      >
        <b-form-input
          id="first-name"
          v-model="appointment.user.firstName"
          type="text"
          placeholder="Vorname"
          :disabled="isDisabled"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group
        id="last-name-group"
        label="Nachname:"
        label-for="last-name"
      >
        <b-form-input
          id="last-name"
          v-model="appointment.user.lastName"
          type="text"
          placeholder="Nachname"
          :disabled="isDisabled"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group
        id="phone-number-group"
        label="Telefon Nummer:"
        label-for="phone-number"
      >
        <b-form-input
          id="phone-number"
          v-model="appointment.user.phoneNumber"
          type="text"
          placeholder="Telefon Nummer"
          :disabled="isDisabled"
          required
        ></b-form-input>
      </b-form-group>

      <!-- <b-form-group id="email-group" label="Email:" label-for="email">
        <b-form-input
          id="email"
          v-model="appointment.user.email"
          type="text"
          placeholder="Email"
          :disabled="isDisabled"
        ></b-form-input>
      </b-form-group> -->

      <b-form-checkbox
        id="privacy-policy"
        v-model="privacyPolicyStatus"
        name="privacy-policy"
        value="accepted"
        unchecked-value="not_accepted"
        class="mb-3"
      >
        <strong
          >Ich habe die Informationen zum
          <span style="text-decoration: underline"
            ><a
              href="https://assalam-ulm.de/privacy-policy/"
              target="_blank"
              rel="noopener"
              >Datenschutzerklärung</a
            ></span
          >
          gelesen und bin damit einverstanden.</strong
        >
      </b-form-checkbox>

      <b-button variant="dark" :disabled="isDisabled" @click="bookNow()">
        Abschließen</b-button
      >
    </b-form>

    <!-- Card info -->
    <b-row>
      <b-col md="6 mx-auto">
        <div class="mt-5">
          <b-card
            bg-variant="info"
            text-variant="white"
            header="Wichtiger Hinweis !"
          >
            <b-card-text
              >Sollten Sie den Gebetstermin nicht wahrnehmen können bzw. Ihre
              Reservation zu annullieren, Bitte Geben Sie die Verwaltung der
              Moschee rechtzeitig Bescheid.<br><br> Telefon Nummer:
              +4917643238452</b-card-text
            >
          </b-card>
        </div>
      </b-col>
    </b-row>
  </b-container>
</template>

<script>
import api from "../shared/data.service";

export default {
  name: "Booking",
  data() {
    return {
      minDate: new Date(),
      privacyPolicyStatus: "not_accepted",
      event: null,
      show: true,
      isDisabled: true,
      availabilityIsShown: false,
      selectedGroupId: null,
      availability: null,
      appointment: {
        date: "",
        group: {},
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
            message: "Es gibt keine freien Plätze in dieser Gruppe",
          }
        : {
            variant: "success",
            message: `${this.availability} Plätze sind noch frei`,
          };
    },
  },
  methods: {
    validateInput() {
      var status = true;
      if (this.selectedGroupId == null) {
        this.isDisabled = true;
        this.makeToast("Bitte wählen Sie eine Gruppe", "Warning", "warning");
        status = false;
      }

      if (!this.appointment.user.firstName.length) {
        this.makeToast(
          "Bitte geben Sie Ihren Vornamen ein",
          "Warning",
          "warning"
        );
        status = false;
      }

      if (!this.appointment.user.lastName.length) {
        this.makeToast(
          "Bitte geben Sie Ihren Nachnamen ein",
          "Warning",
          "warning"
        );
        status = false;
      }

      if (!this.appointment.user.phoneNumber.length) {
        this.makeToast(
          "Bitte geben Sie Ihre Rufnummer ein",
          "Warning",
          "warning"
        );
        status = false;
      }
      if (!this.appointment.date.length) {
        this.makeToast("Bitte wählen Sie ein Datum aus", "Warning", "warning");
        status = false;
      }
      if (this.privacyPolicyStatus == "not_accepted") {
        this.makeToast(
          "Bitte kreuzen Sie das Datenschutz Kontrollbox an",
          "Warning",
          "warning"
        );
        status = false;
      }
      return status;
    },
    bookNow() {
      if (!this.validateInput()) return;
      this.isDisabled = true;
      //console.log(this.appointment);
      this.appointment.event = this.event;
      //console.log(this.appointment.event);
      api.post(
        "appointments",
        this.appointment,
        (response) => {
          if (response.status === 200) {
            this.makeToast(
              "Sie haben erfolgreich einen Platz gebucht",
              "Booked",
              "success"
            );
            setTimeout(() => {
              this.$router.push({
                name: "Events",
                params: { mosqueId: this.event.eventType.mosqueId },
              });
            }, 3000);
          }
          //console.log(response);
        },
        (error) => {
          //console.log(error);
          this.isDisabled = false;
          if (
            error.response &&
            error.response.status == 500 &&
            error.response.data.code === "UserAlreadyHaveAppointment"
          ) {
            this.makeToast(
              "Sie sind schon zu diesem Termin angemeldet, bitte kontaktieren Sie die Moscheeverwaltung",
              "Already booked",
              "warning"
            );
          } else if (error.response && error.response.status == 500) {
            this.makeToast(
              "ein Fehler ist aufgetreten, bitte versuchen Sie später noch einmal",
              "Unknows error",
              "danger"
            );
          }
        }
      );
    },
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
      this.appointment.group = this.event.groups.find(
        (element) => element.id == this.selectedGroupId
      );
      //console.log(this.appointment.group);
      this.availabilityIsShown = true;
      this.availability = this.appointment.group.availability;
    },
    getGroupsByEvent() {
      //console.log(this.appointment.date);
      api.fetch(
        `events/${this.$route.params.eventId}?date=${this.appointment.date}`,
        (response) => {
          //console.log(response);
          this.event = response.data;
          this.dropdownGroups = [
            { value: null, text: " Bitte wählen Sie eine Gruppe " },
          ];
          this.event.groups.forEach((element) => {
            this.dropdownGroups.push({
              text: element.name,
              value: element.id,
            });
          });
        },
        (error) => {
          if (error.response && error.response.status == 404)
            this.makeToast(
              "An diesem Datum gibt es keine Termine, bitte wählen Sie ein anderes Datum.",
              "Date not valid",
              "danger"
            );
          this.isDisabled = true;
          this.dropdownGroups = [];
          this.event = null;
        }
      );
    },
    makeToast(message, title = "", variant = "primary") {
      this.$bvToast.toast(message, {
        title,
        variant,
        solid: true,
      });
    },
  },
};
</script>

<style lang="scss" scoped>
</style>