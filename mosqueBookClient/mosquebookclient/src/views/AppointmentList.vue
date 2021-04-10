<template>
  <b-container>


    <!-- Main table element -->
    <b-table
      head-variant="dark"
      bordered
      hover
      show-empty
      stacked="md"
      :items="events"
      :fields="fields"
      :current-page="currentPage"
      :per-page="perPage"
      :filter="filter"
      :sort-by.sync="sortBy"
      :sort-desc.sync="sortDesc"
      :sort-direction="sortDirection"
      @filtered="onFiltered"
    >
      <template #table-busy class="text-center text-danger my-2">
        <b-spinner class="align-middle"></b-spinner>
        <strong>Chargement...</strong>
      </template>

      <template #cell(FirstName)="row">
        {{ row.value }}
      </template>

       <template #cell(LastName)="row">
        {{ row.value }}
      </template>

       <template #cell(Email)="row">
        {{ row.value }}
      </template>

       <template #cell(PhoneNumber)="row">
        {{ row.value }}
      </template>
      
    </b-table>

  </b-container>
</template>

<script>
// import api from "../shared/data.service";
export default {
  name: "AppointmentList",
  data() {
    return {
      events: [],
      fields: [
        {
          key: "FirstName",
          label: "First name",
          sortable: true,
          sortDirection: "desc",
            class: "text-center",
        },
        { key: "LastName", label: "Late name", sortable: true,  sortDirection: "desc"  , class: "text-center",},
          {
          key: "FirstName",
          label: "First name",
          sortable: true,
          sortDirection: "desc",
            class: "text-center"
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
      ],
      totalRows: 1,
      currentPage: 1,
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
  },
  mounted() {
    // api.fetch("events", (response) => {
    //   this.events = response.data;
    //   this.totalRows = this.events.length;

    //   console.log(response);
    // });
  },
};
</script>

<style lang="scss" scoped>
</style>