<template>
  <div id="app">
    <div>
      <nav>
        <router-link to="/">Home</router-link>
        <router-link to="/booking">Book a place</router-link>
      </nav>
      <main>
        <router-view></router-view>
      </main>
    </div>
  </div>
</template>

<script>

export default {
  name: 'App'

}
</script>

<style>
</style>
