<template>
  <b-container>
    <b-row class="mb-5 text-center">
      <b-col>
        <span v-if="appointments.length">
          {{ appointments[0].event.eventType.name }} -
          {{ appointments[0].group.name }} -
          {{ formatDate(appointments[0].event.date) }}
        </span>
      </b-col>
    </b-row>
    <!-- Main table element -->
    <b-table
      ref="appointmentsTable"
      head-variant="dark"
      bordered
      hover
      show-empty
      stacked="md"
      :items="appointments"
      :fields="fields"
      :per-page="0"
      :filter="filter"
      :sort-by.sync="sortBy"
      :sort-desc.sync="sortDesc"
      :sort-direction="sortDirection"
    >
      <template #cell(FirstName)="row">
        {{ row.item.user.firstName }}
      </template>

      <template #cell(LastName)="row">
        {{ row.item.user.lastName }}
      </template>

      <template #cell(Email)="row">
        {{ row.item.user.email }}
      </template>

      <template #cell(PhoneNumber)="row">
        {{ row.item.user.phoneNumber }}
      </template>

      <template #cell(Signature)=""> </template>

      <template #cell(actions)="row">
        <b-button
          variant="danger mr-1"
          v-b-modal.modal-moteur
          @click="Cancel(row.item.id)"
        >
          Stornieren
        </b-button>
      </template>
    </b-table>
    <b-button
      variant="dark"
      :href="$router.resolve({ name: 'Appointments' }).href"
      class="mr-4"
      >Zurück</b-button
    >
    <b-button onClick="window.print();" variant="primary">Drücken</b-button>
  </b-container>
</template>

<script>
import api from "../shared/data.service";
export default {
  name: "AppointmentList",
  data() {
    return {
      appointments: [],
      fields: [
        {
          key: "FirstName",
          label: "Vorname",
          sortable: true,
          sortDirection: "desc",
          class: "text-center",
        },
        {
          key: "LastName",
          label: "Nachname",
          sortable: true,
          sortDirection: "desc",
          class: "text-center",
        },
        {
          key: "Email",
          label: "Email",
          sortable: true,
          sortDirection: "desc",
          class: "text-center",
        },
        {
          key: "PhoneNumber",
          label: "Telefon Nummer",
          sortable: true,
          sortDirection: "desc",
          class: "text-center",
        },
        {
          key: "Signature",
          label: "Unterschrift",
          sortable: false,
          class: "text-center",
        },
        {
          key: "actions",
          label: "",
          sortable: false,
          class: "text-center",
        },
      ],
      totalRows: 1,
      perPage: 5,
      pageOptions: [5, 10, 15],
      sortBy: null,
      sortDesc: false,
      sortDirection: "asc",
      filter: null,
    };
  },
  methods: {
    Cancel(appointmentId) {
      if (confirm("Diesen Buchung wird gelöscht, sind Sie sicher?!")) {
        api
          .delete("appointments/" + appointmentId, {
            params: { appointmentId },
          })
          .then((response) => {
            if (response.status === 200) {
              this.makeToast(
                "Sie haben erfolgreich einen Buchung gelöscht",
                "Gelöscht",
                "danger"
              );
              this.refreshTable(appointmentId);
            }
          })
          .catch((error) => {
            console.log("Something went wrong" + error);
          });
      }
    },

    refreshTable(appointmentId) {
      const index = this.appointments.findIndex(
        (app) => app.id === appointmentId
      );
      this.appointments.splice(index, 1);
    },
    makeToast(message, title = "", variant = "primary") {
      this.$bvToast.toast(message, {
        title,
        variant,
        solid: true,
      });
    },
    onFiltered(filteredItems) {
      // Trigger pagination to update the number of buttons/pages due to filtering
      this.totalRows = filteredItems.length;
      this.currentPage = 1;
    },
    formatDate(date) {
      // let formatTime = (time) => {
      //   return time < 10 ? '0' + time.toString() : time.toString()
      // };
      date = new Date(date);
      return date.toLocaleDateString();
    },
  },
  mounted() {
    let eventId = this.$route.params.eventId;
    let groupId = this.$route.params.groupId;
    api.fetch(`Appointments/event/${eventId}/group/${groupId}`, (response) => {
      this.appointments = response.data;
      this.totalRows = this.appointments.length;

      console.log(response);
    });
  },
};
</script>

<style lang="scss" scoped>
</style>