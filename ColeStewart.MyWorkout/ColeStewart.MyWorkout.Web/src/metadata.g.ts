import {
  Domain, getEnumMeta, solidify, ModelType, ObjectType,
  PrimitiveProperty, ForeignKeyProperty, PrimaryKeyProperty,
  ModelCollectionNavigationProperty, ModelReferenceNavigationProperty,
  HiddenAreas, BehaviorFlags
} from 'coalesce-vue/lib/metadata'


const domain: Domain = { enums: {}, types: {}, services: {} }
export const WidgetCategory = domain.enums.WidgetCategory = {
  name: "WidgetCategory",
  displayName: "Widget Category",
  type: "enum",
  ...getEnumMeta<"Whizbangs"|"Sprecklesprockets"|"Discombobulators">([
  {
    value: 0,
    strValue: "Whizbangs",
    displayName: "Whizbangs",
  },
  {
    value: 1,
    strValue: "Sprecklesprockets",
    displayName: "Sprecklesprockets",
  },
  {
    value: 2,
    strValue: "Discombobulators",
    displayName: "Discombobulators",
  },
  ]),
}
export const Exercise = domain.types.Exercise = {
  name: "Exercise",
  displayName: "Exercise",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "Exercise",
  get keyProp() { return this.props.exerciseId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    exerciseId: {
      name: "exerciseId",
      displayName: "Exercise Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
      }
    },
    description: {
      name: "description",
      displayName: "Description",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Description is required.",
      }
    },
    difficulty: {
      name: "difficulty",
      displayName: "Difficulty",
      type: "number",
      role: "value",
      rules: {
        required: val => val != null || "Difficulty is required.",
        min: val => val == null || val >= 1 || "Difficulty must be at least 1.",
        max: val => val == null || val <= 5 || "Difficulty may not be more than 5.",
      }
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const SetExercise = domain.types.SetExercise = {
  name: "SetExercise",
  displayName: "Set Exercise",
  get displayProp() { return this.props.setExerciseId }, 
  type: "model",
  controllerRoute: "SetExercise",
  get keyProp() { return this.props.setExerciseId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    setExerciseId: {
      name: "setExerciseId",
      displayName: "Set Exercise Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    exerciseId: {
      name: "exerciseId",
      displayName: "Exercise Id",
      type: "number",
      role: "foreignKey",
      get principalKey() { return (domain.types.Exercise as ModelType).props.exerciseId as PrimaryKeyProperty },
      get principalType() { return (domain.types.Exercise as ModelType) },
      get navigationProp() { return (domain.types.SetExercise as ModelType).props.exercise as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => val != null || "Exercise is required.",
      }
    },
    exercise: {
      name: "exercise",
      displayName: "Exercise",
      type: "model",
      get typeDef() { return (domain.types.Exercise as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.SetExercise as ModelType).props.exerciseId as ForeignKeyProperty },
      get principalKey() { return (domain.types.Exercise as ModelType).props.exerciseId as PrimaryKeyProperty },
      dontSerialize: true,
    },
    workoutSetId: {
      name: "workoutSetId",
      displayName: "Workout Set Id",
      type: "number",
      role: "value",
      rules: {
        required: val => val != null || "Workout Set Id is required.",
      }
    },
    reps: {
      name: "reps",
      displayName: "Reps",
      type: "number",
      role: "value",
    },
    time: {
      name: "time",
      displayName: "Time",
      type: "number",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const User = domain.types.User = {
  name: "User",
  displayName: "User",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "User",
  get keyProp() { return this.props.userId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    userId: {
      name: "userId",
      displayName: "User Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
      }
    },
    birthDate: {
      name: "birthDate",
      displayName: "Birth Date",
      type: "date",
      dateKind: "datetime",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const Widget = domain.types.Widget = {
  name: "Widget",
  displayName: "Widget",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "Widget",
  get keyProp() { return this.props.widgetId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    widgetId: {
      name: "widgetId",
      displayName: "Widget Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
      }
    },
    category: {
      name: "category",
      displayName: "Category",
      type: "enum",
      get typeDef() { return domain.enums.WidgetCategory },
      role: "value",
      rules: {
        required: val => val != null || "Category is required.",
      }
    },
    inventedOn: {
      name: "inventedOn",
      displayName: "Invented On",
      type: "date",
      dateKind: "datetime",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const Workout = domain.types.Workout = {
  name: "Workout",
  displayName: "Workout",
  get displayProp() { return this.props.workoutId }, 
  type: "model",
  controllerRoute: "Workout",
  get keyProp() { return this.props.workoutId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    workoutId: {
      name: "workoutId",
      displayName: "Workout Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    title: {
      name: "title",
      displayName: "Title",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Title is required.",
      }
    },
    description: {
      name: "description",
      displayName: "Description",
      type: "string",
      role: "value",
    },
    workoutSets: {
      name: "workoutSets",
      displayName: "Workout Sets",
      type: "collection",
      itemType: {
        name: "$collectionItem",
        displayName: "",
        role: "value",
        type: "model",
        get typeDef() { return (domain.types.WorkoutSet as ModelType) },
      },
      role: "value",
      dontSerialize: true,
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const WorkoutSet = domain.types.WorkoutSet = {
  name: "WorkoutSet",
  displayName: "Workout Set",
  get displayProp() { return this.props.workoutSetId }, 
  type: "model",
  controllerRoute: "WorkoutSet",
  get keyProp() { return this.props.workoutSetId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    workoutSetId: {
      name: "workoutSetId",
      displayName: "Workout Set Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    workoutName: {
      name: "workoutName",
      displayName: "Workout Name",
      type: "string",
      role: "value",
    },
    workoutId: {
      name: "workoutId",
      displayName: "Workout Id",
      type: "number",
      role: "value",
      rules: {
        required: val => val != null || "Workout Id is required.",
      }
    },
    exercise: {
      name: "exercise",
      displayName: "Exercise",
      type: "collection",
      itemType: {
        name: "$collectionItem",
        displayName: "",
        role: "value",
        type: "model",
        get typeDef() { return (domain.types.SetExercise as ModelType) },
      },
      role: "value",
      dontSerialize: true,
    },
  },
  methods: {
  },
  dataSources: {
  },
}

interface AppDomain extends Domain {
  enums: {
    WidgetCategory: typeof WidgetCategory
  }
  types: {
    Exercise: typeof Exercise
    SetExercise: typeof SetExercise
    User: typeof User
    Widget: typeof Widget
    Workout: typeof Workout
    WorkoutSet: typeof WorkoutSet
  }
  services: {
  }
}

solidify(domain)

export default domain as unknown as AppDomain
