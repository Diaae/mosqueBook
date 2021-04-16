<template>
  <b-container>
    <b-row class="mb-5 text-center">
      <b-col>
        <span v-if="appointments.length"> {{ appointments[0].event.eventType.name}} - {{appointments[0].group.name}} - {{formatDate(appointments[0].event.date)}} </span>
      </b-col>
    </b-row>
    <!-- Main table element -->
    <b-table
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
      <template #table-busy class="text-center text-danger my-2">
        <b-spinner class="align-middle"></b-spinner>
        <strong>Chargement...</strong>
      </template>

      <template #cell(FirstName)="row">
        {{ row.item.user.firstName }}
      </template>

      <template #cell(LastName)="row">
        {{ row.item.user.lastName }}
      </template>

      <template #cell(Email)="row">
        {{ row.item.user.email  }}
      </template>

      <template #cell(PhoneNumber)="row">
        {{  row.item.user.phoneNumber }}
      </template>
      
      <template #cell(Signature)="">

      </template>
    </b-table>
     <b-button  variant="danger" :href= "$router.resolve({name:'Appointments'}).href" class="mr-4">Go Back</b-button>
     <b-button onClick="window.print();" variant="primary" >Print</b-button>
     
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
          label: "First name",
          sortable: true,
          sortDirection: "desc",
          class: "text-center",
        },
        {
          key: "LastName",
          label: "Last name",
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
          label: "Phone number",
          sortable: true,
          sortDirection: "desc",
          class: "text-center",
        },
        {
          key: "Signature",
          label: "Signature",
          sortable: false,
          class: "text-center",
        }
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
      }
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