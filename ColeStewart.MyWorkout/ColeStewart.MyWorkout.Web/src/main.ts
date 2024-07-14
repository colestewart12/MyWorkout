import { createApp } from "vue";
import { createVuetify } from "vuetify";
import { createCoalesceVuetify } from "coalesce-vue-vuetify3";
import { aliases, fa } from "vuetify/iconsets/fa";
import { AxiosClient as CoalesceAxiosClient } from "coalesce-vue";

import App from "./App.vue";
import router from "./router";

// Import global CSS and Fonts:
import "typeface-roboto";
import "@fortawesome/fontawesome-free/css/all.css";
import "coalesce-vue-vuetify3/styles.css";
import "@/site.scss";
import "vuetify/styles";
import { DARK_THEME } from "@/lib/symbols";

import $metadata from "@/metadata.g";
// viewmodels.g has side effects - it populates the global lookup on ViewModel and ListViewModel.
// This global lookup allows the admin page components to function.
import "@/viewmodels.g";

// SETUP: vuetify
const inputDefaults = { density: "compact", variant: "outlined" };
const vuetify = createVuetify({
  icons: {
    defaultSet: "fa",
    aliases,
    sets: { fa },
  },
  defaults: {
    VTextField: inputDefaults,
    VTextarea: inputDefaults,
    VSelect: inputDefaults,
    VCombobox: inputDefaults,
    VAutocomplete: inputDefaults,
    VField: inputDefaults,
    VInput: inputDefaults,
    VSwitch: { color: "primary" }, // https://github.com/vuetifyjs/vuetify/issues/16486
  },
  theme: {
    defaultTheme: localStorage.getItem(DARK_THEME) === "true" ? "dark" : "dark",
    variations: {
      colors: ["primary", "secondary"],
      lighten: 5,
      darken: 5,
    },
    themes: {
      light: {
        colors: {
          primary: "#ff0000", // Red color for primary in light theme
          secondary: "#ffcccc", // Light red for secondary
          accent: "#ff6666", // Slightly darker red for accent
          error: "#ff4444", // Darker red for error messages
          background: "#ffffff", // White background for light theme
          surface: "#ffffff", // White surface for light theme
          onPrimary: "#ffffff", // White text on primary red
          onSecondary: "#000000", // Black text on secondary light red
          onError: "#ffffff", // White text on error red
          onBackground: "#000000", // Black text on white background
          onSurface: "#000000", // Black text on white surface
        },
      },
      dark: {
        colors: {
          primary: "#ff0000", // Red color for primary in dark theme
          secondary: "#660000", // Dark red for secondary
          accent: "#ff6666", // Slightly lighter red for accent
          error: "#ff4444", // Darker red for error messages
          background: "#000000", // Black background for dark theme
          surface: "#121212", // Dark gray surface for dark theme
          onPrimary: "#000000", // Black text on primary red
          onSecondary: "#ffffff", // White text on secondary dark red
          onError: "#000000", // Black text on error red
          onBackground: "#ffffff", // White text on black background
          onSurface: "#ffffff", // White text on dark gray surface
        },
      },
    },
  },
});

// SETUP: coalesce-vue
CoalesceAxiosClient.defaults.baseURL = "/api";
CoalesceAxiosClient.defaults.withCredentials = true;

// SETUP: coalesce-vue-vuetify
const coalesceVuetify = createCoalesceVuetify({
  metadata: $metadata,
});

const app = createApp(App);
app.use(router);
app.use(vuetify);
app.use(coalesceVuetify);
app.mount("#app");
