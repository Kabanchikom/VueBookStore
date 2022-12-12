<template>
  <div>
      <div class="card">
        <div class="image-container">
          <div class="first">
            <div class="d-flex justify-content-between align-items-center">
              <span v-if="this.discountPercent !== 0" class="discount">{{ this.discountPercent }}%</span>
              <span v-else></span>
              <span class="wishlist"><i class="bi bi-suit-heart"></i></span>
            </div>
          </div>
          <img :src="product.thumbImagePath" class="img-fluid rounded thumbnail-image">
        </div>
        <div class="product-detail-container p-2">
          <div class="d-flex justify-content-between align-items-center">
            <h5 class="product-name">{{ product.name }}</h5>
            <div class="d-flex flex-column mb-2">
              <span class="new-price">{{ displayPrice }} ₽</span>
              <small v-if="product.oldPrice !== displayPrice" class="old-price text-right">{{ product.oldPrice }} ₽</small>
            </div>
          </div>
          <div class="d-flex justify-content-between align-items-center pt-1">
            <div class="display-authors d-flex ">
              <span>{{ displayAuthors }}</span>
            </div>
            <div class="d-flex">
              <span>
                <button class="btn btn-success">
                  <i class="bi bi-cart"></i>
                </button>
              </span>
            </div>
          </div>
          <div class="d-flex justify-content-between align-items-center pt-1">
            <div>
              <span class="rating-number"><i class="bi bi-star-fill"></i> {{ product.rating }}</span>
            </div>
          </div>
        </div>
      </div>
  </div>
</template>

<script>
export default {
  name: "product-card",
  props: {
    product: Object,
    required: true,
  },
  methods: {
    getInitials(author) {
      if (author.surname === null)
      {
        return author.name;
      }

      let initials = author.name[0] + ".";

      if (author.patronimic !== null)
      {
        initials += author.patronimic[0] + ".";
      }

      initials += " " + author.surname;

      return initials;
    }
  },
  computed: {
    discountPercent() {
      return this.product.newPrice === null
          ? 0
          : Math.round((this.product.oldPrice - this.product.newPrice) / this.product.oldPrice * 100);
    },
    discount() {
      return this.product.oldPrice - this.product.newPrice;
    },
    displayPrice() {
      return this.product.newPrice === null ? this.product.oldPrice : this.product.newPrice;
    },
    displayAuthors() {
      return this.product.authors.map(x => this.getInitials(x)).join(", ")
    }
  }
}
</script>

<style scoped lang="scss">
.card {
  background-color: #fff;
  border: none;
  border-radius: 10px;
  margin: 20px 20px;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);

  .image-container {
    position: relative;

    .first {
      position: absolute;
      width: 100%;
      padding: 9px;

      .discount {
        background-color: red;
        padding: 1px 4px;
        font-size: 10px;
        border-radius: 6px;
        color: #fff;
      }

      .wishlist {
        height: 25px;
        width: 25px;
        background-color: #eee;
        display: flex;
        justify-content: center;
        align-items: center;
        border-radius: 50%;
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
      }
    }

    .thumbnail-image {
      border-radius: 10px !important;
    }

    img {
      width: 100%
    }
  }

  .product-detail-container {
    .product-name {
      font-size: 15px;
      font-weight: bold;
      width: 75%;
    }

    .new-price {
      font-size: 12px;
      font-weight: bold;
      color: red;
    }

    .old-price {
      font-size: 12px;
      font-weight: bold;
      color: grey;
      text-decoration: line-through;
    }

    .rating-number {
      font-size: 12px;
      color: grey;
    }

    .display-authors {
      font-size: 12px;
      color: grey;
    }

    .bi-star-fill {
      color: orange;
    }
  }
}
</style>