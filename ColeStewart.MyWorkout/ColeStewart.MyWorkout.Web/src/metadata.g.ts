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
export const Bracket = domain.types.Bracket = {
  name: "Bracket",
  displayName: "Bracket",
  get displayProp() { return this.props.bracketId }, 
  type: "model",
  controllerRoute: "Bracket",
  get keyProp() { return this.props.bracketId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    bracketId: {
      name: "bracketId",
      displayName: "Bracket Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    bracketName: {
      name: "bracketName",
      displayName: "Bracket Name",
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
    exercises: {
      name: "exercises",
      displayName: "Exercises",
      type: "collection",
      itemType: {
        name: "$collectionItem",
        displayName: "",
        role: "value",
        type: "model",
        get typeDef() { return (domain.types.BracketExercise as ModelType) },
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
export const BracketExercise = domain.types.BracketExercise = {
  name: "BracketExercise",
  displayName: "Bracket Exercise",
  get displayProp() { return this.props.bracketExerciseId }, 
  type: "model",
  controllerRoute: "BracketExercise",
  get keyProp() { return this.props.bracketExerciseId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    bracketExerciseId: {
      name: "bracketExerciseId",
      displayName: "Bracket Exercise Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    exerciseId: {
      name: "exerciseId",
      displayName: "Exercise Id",
      type: "number",
      role: "value",
      rules: {
        required: val => val != null || "Exercise Id is required.",
      }
    },
    bracketId: {
      name: "bracketId",
      displayName: "Bracket Id",
      type: "number",
      role: "value",
      rules: {
        required: val => val != null || "Bracket Id is required.",
      }
    },
    weight: {
      name: "weight",
      displayName: "Weight",
      type: "number",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
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
    brackets: {
      name: "brackets",
      displayName: "Brackets",
      type: "collection",
      itemType: {
        name: "$collectionItem",
        displayName: "",
        role: "value",
        type: "model",
        get typeDef() { return (domain.types.Bracket as ModelType) },
      },
      role: "value",
      dontSerialize: true,
    },
  },
  methods: {
  },
  dataSources: {
    workoutDataSource: {
      type: "dataSource",
      name: "WorkoutDataSource",
      displayName: "Workout Data Source",
      isDefault: true,
      props: {
      },
    },
  },
}

interface AppDomain extends Domain {
  enums: {
    WidgetCategory: typeof WidgetCategory
  }
  types: {
    Bracket: typeof Bracket
    BracketExercise: typeof BracketExercise
    Exercise: typeof Exercise
    User: typeof User
    Widget: typeof Widget
    Workout: typeof Workout
  }
  services: {
  }
}

solidify(domain)

export default domain as unknown as AppDomain
