<template>
    <b-container>
        <b-form @submit="onSubmit"  v-if="show">
        <b-form-group
            id="first-name-group"
            label="First Name:"
            label-for="first-name"
        >
            <b-form-input
            id="first-name"
            v-model="mosqueBooking.firstName"
            type="text"
            placeholder="First Name"
            required
            ></b-form-input>
        </b-form-group>
        
        <b-form-group
            id="last-name-group"
            label="Last Name:"
            label-for="last-name"
        >
            <b-form-input
            id="last-name"
            v-model="mosqueBooking.lastName"
            type="text"
            placeholder="Last Name"
            required
            ></b-form-input>
        </b-form-group>
        
        <b-form-group
            id="phone-number-group"
            label="Phone Number:"
            label-for="phone-number"
        >
            <b-form-input
            id="phone-number"
            v-model="mosqueBooking.phoneNumber"
            type="text"
            placeholder="Phone Number"
            required
            ></b-form-input>
        </b-form-group>
        
        <b-form-group
            id="email-group"
            label="Email:"
            label-for="email"
        >
            <b-form-input
            id="email"
            v-model="mosqueBooking.email"
            type="text"
            placeholder="Email"
            required
            ></b-form-input>
        </b-form-group>

        <b-button type="submit" variant="dark">Book Now</b-button>
        </b-form>  
    </b-container>
</template>

<script>
    export default {
        name: "Booking",
        data(){
            return{
                show: true,
                mosqueBooking: {
                    firstName : '',
                    lastName: '',
                    phoneNumber: '',
                    email: ''
                },
            }
        },
        methods: {
            onSubmit() {
                
            }
        },
    }
</script>

<style lang="scss" scoped>

</style>