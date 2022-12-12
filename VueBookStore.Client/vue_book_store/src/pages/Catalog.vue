<template>
  <div>
    <div class="container mt-5">
      <div class="row">
        <div v-for="product in products" class="col-md-3">
          <product-card :product="product" :key="product.id"/>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";
import ProductCard from "@/components/product/ProductCard";

export default {
  name: "Catalog",
  components: {ProductCard},
  data() {
    return {
      products: []
    }
  },
  methods: {
    async fetchProducts() {
      try {
        const response = await axios.get('https://localhost:7232/api/products');
        this.products = response.data
      } catch (e) {
        alert('Ошибка')
      }
    }
  },
  mounted() {
    this.fetchProducts();
  }
}
</script>

<style scoped>
body{
  background-color: #eee;
}
.container{
  width: 1200px;
}
</style>