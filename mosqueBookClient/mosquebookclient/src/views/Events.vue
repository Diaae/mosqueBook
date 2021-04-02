<template>
    <b-container>
      <b-table stacked="md" striped hover :items="events">
        <template v-slot:cell(groups)="row">
          <b-badge class="p-2 mb-1 mr-1" v-for="group in row.item.groups" :key="group.id"
           :variant="group.isFull?'danger':'success'"> {{group.name}} 
          </b-badge>
        </template>
      </b-table>
    </b-container>
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
          groups: [
            {
              id: "1",
              name: "group 1",
              isFull: true
            },
            {
              id: "2",
              name: "group 2",
              isFull: false
            }
          ],
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
          groups: [
            {
              id: "3",
              name: "group 3",
              isFull: true
            },
            {
              id: "4",
              name: "group 5",
              isFull: false
            }
          ],
        },
      ],
    };
  },
};
</script>

<style lang="scss" scoped>
</style>