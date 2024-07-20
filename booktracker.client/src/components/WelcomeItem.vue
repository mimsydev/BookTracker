<template>
  <div class="item">
    <i class="text-purple-90">
      <slot name="icon"></slot>
    </i>
    <div class="details">
      <h3 class="text-3xl font-bold underline">
        <slot name="heading"></slot>
      </h3>
      <slot></slot>
    </div>
  </div>
</template>

