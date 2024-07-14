import * as $metadata from './metadata.g'
import * as $models from './models.g'
import * as $apiClients from './api-clients.g'
import { ViewModel, ListViewModel, ServiceViewModel, DeepPartial, defineProps } from 'coalesce-vue/lib/viewmodel'

export interface ExerciseViewModel extends $models.Exercise {
  exerciseId: number | null;
  name: string | null;
  description: string | null;
  difficulty: number | null;
}
export class ExerciseViewModel extends ViewModel<$models.Exercise, $apiClients.ExerciseApiClient, number> implements $models.Exercise  {
  
  constructor(initialData?: DeepPartial<$models.Exercise> | null) {
    super($metadata.Exercise, new $apiClients.ExerciseApiClient(), initialData)
  }
}
defineProps(ExerciseViewModel, $metadata.Exercise)

export class ExerciseListViewModel extends ListViewModel<$models.Exercise, $apiClients.ExerciseApiClient, ExerciseViewModel> {
  
  constructor() {
    super($metadata.Exercise, new $apiClients.ExerciseApiClient())
  }
}


export interface SetExerciseViewModel extends $models.SetExercise {
  setExerciseId: number | null;
  exerciseId: number | null;
  exercise: ExerciseViewModel | null;
  workoutSetId: number | null;
  reps: number | null;
  time: number | null;
}
export class SetExerciseViewModel extends ViewModel<$models.SetExercise, $apiClients.SetExerciseApiClient, number> implements $models.SetExercise  {
  
  constructor(initialData?: DeepPartial<$models.SetExercise> | null) {
    super($metadata.SetExercise, new $apiClients.SetExerciseApiClient(), initialData)
  }
}
defineProps(SetExerciseViewModel, $metadata.SetExercise)

export class SetExerciseListViewModel extends ListViewModel<$models.SetExercise, $apiClients.SetExerciseApiClient, SetExerciseViewModel> {
  
  constructor() {
    super($metadata.SetExercise, new $apiClients.SetExerciseApiClient())
  }
}


export interface UserViewModel extends $models.User {
  userId: number | null;
  name: string | null;
  birthDate: Date | null;
}
export class UserViewModel extends ViewModel<$models.User, $apiClients.UserApiClient, number> implements $models.User  {
  
  constructor(initialData?: DeepPartial<$models.User> | null) {
    super($metadata.User, new $apiClients.UserApiClient(), initialData)
  }
}
defineProps(UserViewModel, $metadata.User)

export class UserListViewModel extends ListViewModel<$models.User, $apiClients.UserApiClient, UserViewModel> {
  
  constructor() {
    super($metadata.User, new $apiClients.UserApiClient())
  }
}


export interface WidgetViewModel extends $models.Widget {
  widgetId: number | null;
  name: string | null;
  category: $models.WidgetCategory | null;
  inventedOn: Date | null;
}
export class WidgetViewModel extends ViewModel<$models.Widget, $apiClients.WidgetApiClient, number> implements $models.Widget  {
  
  constructor(initialData?: DeepPartial<$models.Widget> | null) {
    super($metadata.Widget, new $apiClients.WidgetApiClient(), initialData)
  }
}
defineProps(WidgetViewModel, $metadata.Widget)

export class WidgetListViewModel extends ListViewModel<$models.Widget, $apiClients.WidgetApiClient, WidgetViewModel> {
  
  constructor() {
    super($metadata.Widget, new $apiClients.WidgetApiClient())
  }
}


export interface WorkoutViewModel extends $models.Workout {
  workoutId: number | null;
  title: string | null;
  description: string | null;
  workoutSets: WorkoutSetViewModel[] | null;
}
export class WorkoutViewModel extends ViewModel<$models.Workout, $apiClients.WorkoutApiClient, number> implements $models.Workout  {
  
  constructor(initialData?: DeepPartial<$models.Workout> | null) {
    super($metadata.Workout, new $apiClients.WorkoutApiClient(), initialData)
  }
}
defineProps(WorkoutViewModel, $metadata.Workout)

export class WorkoutListViewModel extends ListViewModel<$models.Workout, $apiClients.WorkoutApiClient, WorkoutViewModel> {
  
  constructor() {
    super($metadata.Workout, new $apiClients.WorkoutApiClient())
  }
}


export interface WorkoutSetViewModel extends $models.WorkoutSet {
  workoutSetId: number | null;
  workoutName: string | null;
  workoutId: number | null;
  exercise: SetExerciseViewModel[] | null;
}
export class WorkoutSetViewModel extends ViewModel<$models.WorkoutSet, $apiClients.WorkoutSetApiClient, number> implements $models.WorkoutSet  {
  
  constructor(initialData?: DeepPartial<$models.WorkoutSet> | null) {
    super($metadata.WorkoutSet, new $apiClients.WorkoutSetApiClient(), initialData)
  }
}
defineProps(WorkoutSetViewModel, $metadata.WorkoutSet)

export class WorkoutSetListViewModel extends ListViewModel<$models.WorkoutSet, $apiClients.WorkoutSetApiClient, WorkoutSetViewModel> {
  
  constructor() {
    super($metadata.WorkoutSet, new $apiClients.WorkoutSetApiClient())
  }
}


const viewModelTypeLookup = ViewModel.typeLookup = {
  Exercise: ExerciseViewModel,
  SetExercise: SetExerciseViewModel,
  User: UserViewModel,
  Widget: WidgetViewModel,
  Workout: WorkoutViewModel,
  WorkoutSet: WorkoutSetViewModel,
}
const listViewModelTypeLookup = ListViewModel.typeLookup = {
  Exercise: ExerciseListViewModel,
  SetExercise: SetExerciseListViewModel,
  User: UserListViewModel,
  Widget: WidgetListViewModel,
  Workout: WorkoutListViewModel,
  WorkoutSet: WorkoutSetListViewModel,
}
const serviceViewModelTypeLookup = ServiceViewModel.typeLookup = {
}

