<template>
  <div id="app">
    <div>
      <nav-bar class="mb-4">
      </nav-bar>
      <main>
        <router-view></router-view>
      </main>
    </div>
  </div>
</template>

<script>
import navbar from "./components/Nav"
export default {
  name: 'App',
  components: {
    "nav-bar" : navbar
  }

}
</script>

<style>
</style>
