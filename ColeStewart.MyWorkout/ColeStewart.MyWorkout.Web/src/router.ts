import { createRouter, createWebHistory } from "vue-router";
import { CAdminEditorPage, CAdminTablePage } from "coalesce-vue-vuetify3";

export default createRouter({
  history: createWebHistory(),
  routes: [
    {
      path: "/",
      name: "home",
      component: () => import("./views/Home.vue"),
    },
    {
      path: "/widget/:id(\\d+)?",
      name: "widget-edit",
      component: () => import("./views/WidgetEdit.vue"),
      props: (r) => ({ id: +r.params.id }),
    },
    {
      path: "/admin",
      name: "admin",
      component: () => import("./views/Admin.vue"),
    },
    {
      path: "/user",
      name: "person-details",
      component: () => import("@/views/User.vue"),
    },
    {
      path: "/workout",
      name: "workout-page",
      component: () => import("@/views/Workouts.vue"),
      props: (route) => ({ id: +route.params.id }),
    },
    {
      path: "/workout/:workoutId",
      name: "workout-details",
      component: () => import("@/views/Workout.vue"),
      props: (route) => ({ workoutId: +route.params.workoutId }),
    },
    {
      path: "/exercise",
      name: "exercise-page",
      component: () => import("@/views/Exercises.vue"),
    },
    {
      path: "/exercise/:exerciseId",
      name: "exercise-details",
      component: () => import("@/views/Exercise.vue"),
      props: (route) => ({ exerciseId: +route.params.exerciseId }),
    },

    // Coalesce admin routes
    {
      path: "/admin/:type",
      name: "coalesce-admin-list",
      component: titledAdminPage(CAdminTablePage),
      props: true,
    },
    {
      path: "/admin/:type/edit/:id?",
      name: "coalesce-admin-item",
      component: titledAdminPage(CAdminEditorPage),
      props: true,
    },
  ],
});

/** Creates a wrapper component that will pull page title from the
 *  coalesce admin page component and pass it to `useTitle`.
 */
function titledAdminPage<
  T extends typeof CAdminTablePage | typeof CAdminEditorPage,
>(component: T) {
  return defineComponent({
    setup() {
      const pageRef = ref<InstanceType<T>>();
      useTitle(() => pageRef.value?.pageTitle);
      return { pageRef };
    },
    render() {
      return h(component, {
        color: "primary",
        ref: "pageRef",
        ...this.$attrs,
      });
    },
  });
}
