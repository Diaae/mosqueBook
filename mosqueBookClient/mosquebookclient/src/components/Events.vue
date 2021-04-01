<template>
  <div class="row clearfix">
    <div class="col-lg-10 col-md-12 col-sm-12" style="margin: 0 auto">
      <div class="card">
        <div class="header">
          <h2>Events List</h2>
        </div>
        <div class="body">
          <div class="table-responsive">
            <table class="table table-striped">
              <!-- HEADER -->
              <thead>
                <tr>
                  <th>Event name</th>
                  <th>Date</th>
                  <th>Availability</th>
                  <th>Groups</th>
                  <th>Description</th>
                  <th>Action</th>
                </tr>
              </thead>
              <!-- BODY ROWS -->
              <tbody>
                <tr v-for="event in events" :key="event.id">
                  <!-- Event name -->
                  <td>{{ event.eventType.name }}</td>
                  <!-- Event date -->
                  <td>
                    <div class="input-group masked-input">
                      <input
                        v-model="event.dateTime"
                        type="date"
                        class="form-control date"
                      />
                    </div>
                  </td>
                  <!-- Availability -->
                  <td> 158 </td>
                  <!-- Groups -->
                  <td>
                    <select
                      v-model="event.groups"
                      class="form-control show-tick ms select2"
                      data-placeholder="Select"
                      @keyup.esc="clearPower"
                      @keyup.enter="validate"
                    >
                      <option default>Group 1</option>
                      <option>Group 2</option>
                    </select>
                  </td>
                  <!-- Event description -->
                  <td>{{ event.description }}</td>
                  <!-- Event action -->
                  <td>
                    <button class="btn btn-primary">Book</button>
                  </td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "Events",
  data() {
    return {
      events: [
        {
          id: "d8579b21-99ed-4f94-9188-221e63a96628",
          eventType: {
            id: "ade17efa-23c6-4a1b-8aa9-d1f825f6979a",
            name: "Al-Fajr",
            description: "Alhamdulilah",
          },
          description: "Allaaaahu akbar",
          dateTime: "0001-01-01T00:00:00",
          groups: 2,
        },

        {
          id: "d8579b21-99ed-4f94-9188-221e63a96627",
          eventType: {
            id: "ade17efa-23c6-4a1b-8aa9-d1f825f6979j",
            name: "Al-Dohr",
            description: "Alhamdulilah",
          },
          description: "Allaaaahu akbar",
          dateTime: "0001-01-01T00:00:00",
          groups: 1,
        },
      ],
    };
  },

  methods: {
    clearPower() {
      this.events.groups = "";
    },
  },
};
</script>

<style>
</style>