import { ref, watch, nextTick } from "vue";
import { VForm } from "vuetify/components";

/** Use to validate a form when the model value changes.
 * @param formInstance The VForm instance to validate
 * @param modelValue The model value to watch for changes
 * @returns A ref that is true when the form is valid
 */

export function useFormValidation(
  formInstance: Ref<VForm | undefined>,
  modelValue: Ref<boolean>
) {
  const formIsValid = ref(false);

  onMounted(() => {
    (formInstance.value as VForm)?.validate();
  });

  watch(modelValue, (value) => {
    if (value) {
      nextTick().then(() => {
        (formInstance.value as VForm)?.validate();
      });
    }
  });

  return formIsValid;
}