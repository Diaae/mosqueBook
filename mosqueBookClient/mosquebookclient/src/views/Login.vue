<template>
  <b-container>
    <h1>Login</h1>
    <b-form-group id="name-group" label="Email:" label-for="email">
      <b-form-input
        id="email"
        v-model="user.email"
        type="text"
        placeholder="Email"
        required
      ></b-form-input>
    </b-form-group>
    <b-form-group id="name-group" label="Password:" label-for="pwd">
      <b-form-input
        id="pwd"
        v-model="user.pwd"
        type="password"
        placeholder="Password"
        required
      ></b-form-input>
    </b-form-group>

    <b-button @click="login()" variant="dark">Login</b-button>
  </b-container>
</template>

<script>
import api from "../shared/data.service";

export default {
  name: "Login",
  data() {
    return {
      user: {
        email: "",
        pwd: "",
      },
    };
  },
  methods: {
    login() {
      if (this.user.email.length && this.user.pwd.length) {
        let data = {
          username: this.user.email,
          password: this.user.pwd
        };
        api.post("Users/authenticate",data,(response)=>{
            if(response.status === 200){
                localStorage.setItem("token",response.data.token);
                this.$router.push('/appointments');
            }
        },(error)=>{
            if(error.response.status === 400){
                alert("Incorrect login or password");
            }
        });
      }
    },
  },
};
</script>

<style>
</style>