<template>
  <b-container>
    <b-row>
      <b-col md="6" class="my-1">
        <b-form-group label-cols-sm="3" label="Filter" class="mb-0">
          <b-input-group>
            <b-form-input
              v-model="filter"
              placeholder="Input a value"
            ></b-form-input>
            <b-input-group-append>
              <b-button :disabled="!filter" @click="filter = ''"
                >Clear</b-button
              >
            </b-input-group-append>
          </b-input-group>
        </b-form-group>
      </b-col>
      <b-col md="6" class="my-1">
        <b-form-group label-cols-sm="3" label="Per page" class="mb-0">
          <b-form-select
            v-model="perPage"
            :options="pageOptions"
          ></b-form-select>
        </b-form-group>
      </b-col>
    </b-row>

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


      <template #cell(eventType)="row">
        {{ row.value.name }}
      </template>
      <template #cell(actions)="row">
        <b-button
          variant="primary mr-1"
          v-b-modal.modal-moteur
          @click="Book(row.item.id)"
        >
          Book
        </b-button>
      </template>
    </b-table>

    <b-row>
      <b-col md="6" class="my-1">
        <b-pagination
          v-model="currentPage"
          :total-rows="totalRows"
          :per-page="perPage"
          class="my-0"
        ></b-pagination>
      </b-col>
    </b-row>
  </b-container>
</template>

<script>
import api from "../shared/data.service";
export default {
  name: "Events",
  data() {
    return {
      events: [],
      fields: [
        {
          key: "name",
          label: "Event Type",
          sortable: true,
          sortDirection: "desc",
        },
        {
          key: "description",
          label: "Description",
          sortable: true,
          class: "text-center",
        },
        { key: "actions", label: "Actions" },
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
    Book(eventId) {
      this.$router.push({
        name: "Booking",
        params: { eventId },
      });
    },
  },
  mounted() {
    api.fetch("eventTypes", (response) => {
      this.events = response.data;
      this.totalRows = this.events.length;
      console.log(response);
    });
  },
};
</script>

<style lang="scss" scoped>
</style>