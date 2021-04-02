<template>
  <b-container>
    <b-form @submit="onSubmit" @reset="onReset" v-if="show">
      <b-form-group id="name-group" label="Name:" label-for="name">
        <b-form-input
          id="name-id"
          v-model="form.name"
          type="text"
          placeholder="Enter mosque's name"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group id="address-group" label="Address:" label-for="address">
        <b-form-input
          id="address-id"
          v-model="form.address"
          placeholder="Enter mosque's address"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group id="email-group" label="Email:" label-for="email">
        <b-form-input
          id="email-id"
          v-model="form.email"
          placeholder="Enter mosque's email"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group id="phone-group" label="Phone:" label-for="phone">
        <b-form-input
          id="phone-id"
          v-model="form.phone"
          placeholder="Enter mosque's phone number"
          required
        ></b-form-input>
      </b-form-group>

      <b-button type="submit" variant="primary" class="mr-4">Submit</b-button>
      <b-button type="reset" variant="danger"
      :href= "$router.resolve({name:'Mosques'}).href">Go Back</b-button>
    </b-form>
  </b-container>
</template>

<script>
export default {
  data() {
    return {
      form: {
        email: "",
        name: "",
        food: null,
        checked: [],
      },
      foods: [
        { text: "Select One", value: null },
        "Carrots",
        "Beans",
        "Tomatoes",
        "Corn",
      ],
      show: true,
    };
  },
  methods: {
    onSubmit(event) {
      event.preventDefault();
      alert(JSON.stringify(this.form));
    },
    onReset(event) {
      event.preventDefault();
      // Reset our form values
      this.form.email = "";
      this.form.name = "";
      this.form.food = null;
      this.form.checked = [];
      // Trick to reset/clear native browser form validation state
      this.show = false;
      this.$nextTick(() => {
        this.show = true;
      });
    },
  },
};
</script>

<style lang="scss" scoped>
</style>