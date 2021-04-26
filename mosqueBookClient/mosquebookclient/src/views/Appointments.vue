<template>
  <b-container>
    <b-row>
      <b-col md="6" class="my-1">
        <b-form-group
          id="datepicker"
          label-cols-sm="3"
          label="Datum :"
          class="mb-0"
        >
          <b-input-group>
            <b-form-datepicker
              id="bookingDate"
              class="mb-2"
              placeholder="Wann?"
              v-model="filter"
            ></b-form-datepicker>
            <b-input-group-append>
              <b-button :disabled="!filter" @click="filter = ''"
                >Entfernen</b-button
              >
            </b-input-group-append>
          </b-input-group>
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
      :filter-function="filterTable"
      @filtered="onFiltered"
    >
      <template #table-busy class="text-center text-danger my-2">
        <b-spinner class="align-middle"></b-spinner>
        <strong>Bitte haben Sie Geduld...</strong>
      </template>

      <template #cell(groups)="row">
        <b-select
          id="selectGroup"
          text="Select a group"
          block
          variant="primary"
          :options="row.item.groups"
          value-field="id"
          text-field="name"
          v-model="row.item.selectedGroupId"
        >
          <template #first>
            <b-select-option :value="null" disabled v-model="selected"
              >-- Bitte wähle eine Option --</b-select-option
            >
          </template>
        </b-select>
      </template>

      <template #cell(eventType)="row">
        {{ row.value.name }}
      </template>

      <template #cell(date)="row">
        {{ formatDate(row.value) }}
      </template>
      <template #cell(actions)="row">
        <b-button
          :ref="'btn' + row.item.id"
          variant="primary mr-1"
          v-b-modal.modal-moteur
          @click="Book(row.item.id,row.item.selectedGroupId)"
          :disabled="row.item.selectedGroupId == null"
        >
          Mehr anzeigen
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
//bghitihom ikono disabled flbdya oui
import api from "../shared/data.service";
export default {
  name: "Appointments",
  data() {
    return {
      buttonStatus: [],
      events: [],
      fields: [
        {
          key: "eventType",
          label: "Salat",
          sortable: true,
          sortDirection: "desc",
        },
        { key: "date", label: "Datum", sortable: true, class: "text-center" },
        {
          key: "groups",
          label: "Gruppen",
          sortable: true,
          class: "text-center",
        },
        { key: "actions", label: "" },
      ],
      selectedGroupId: null,
      totalRows: 1,
      currentPage: 1,
      perPage: 10,
      pageOptions: [5, 10, 15],
      sortBy: null,
      sortDesc: false,
      sortDirection: "asc",
      filter: null,
      dropdownGroups: [],
    };
  },
  methods: {
    filterTable(row, filter) {
      if (this.formatDate(filter) == this.formatDate(row.date)) {
        return true;
      } else {
        return false;
      }
    },
    onFiltered(filteredItems) {
      // Trigger pagination to update the number of buttons/pages due to filtering
      this.totalRows = filteredItems.length;
      this.currentPage = 1;
    },
    Book(eventId,groupId) {
      this.$router.push({
        name: "AppointmentList",
        params: { eventId, groupId: groupId },
      });
    },
    formatDate(date) {
      // let formatTime = (time) => {
      //   return time < 10 ? "0" + time.toString() : time.toString();
      // };
      date = new Date(date);
      return date.toLocaleDateString();
    },
  },
  mounted() {
    api.fetch("events", (response) => {
      this.events = response.data;
      this.totalRows = this.events.length;
      
      console.log(response);
    });
  },
};
</script>

<style lang="scss" scoped>
</style>