<template>
  <b-container>
    <b-button
      block
      variant="primary"
      class="mb-4"
      :href="$router.resolve({ name: 'MosquesAdd' }).href"
    >
      Add mosque
    </b-button>
    <b-table stacked="md" :items="items"></b-table>
  </b-container>
</template>

<script>
export default {
  name: "Mosque",
  data() {
    return {
      items: [
        { age: 40, first_name: "Dickerson", last_name: "Macdonald" },
        { age: 21, first_name: "Larsen", last_name: "Shaw" },
        { age: 89, first_name: "Geneva", last_name: "Wilson" },
      ],
    };
  },
};
</script>

<style lang="scss" scoped>
</style>