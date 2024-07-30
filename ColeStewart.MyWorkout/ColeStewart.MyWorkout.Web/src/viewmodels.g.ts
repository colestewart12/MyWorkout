import * as $metadata from './metadata.g'
import * as $models from './models.g'
import * as $apiClients from './api-clients.g'
import { ViewModel, ListViewModel, ServiceViewModel, DeepPartial, defineProps } from 'coalesce-vue/lib/viewmodel'

export interface BracketViewModel extends $models.Bracket {
  bracketId: number | null;
  bracketName: string | null;
  workoutId: number | null;
  exercises: BracketExerciseViewModel[] | null;
}
export class BracketViewModel extends ViewModel<$models.Bracket, $apiClients.BracketApiClient, number> implements $models.Bracket  {
  
  constructor(initialData?: DeepPartial<$models.Bracket> | null) {
    super($metadata.Bracket, new $apiClients.BracketApiClient(), initialData)
  }
}
defineProps(BracketViewModel, $metadata.Bracket)

export class BracketListViewModel extends ListViewModel<$models.Bracket, $apiClients.BracketApiClient, BracketViewModel> {
  
  constructor() {
    super($metadata.Bracket, new $apiClients.BracketApiClient())
  }
}


export interface BracketExerciseViewModel extends $models.BracketExercise {
  bracketExerciseId: number | null;
  exerciseId: number | null;
  bracketId: number | null;
  weight: number | null;
}
export class BracketExerciseViewModel extends ViewModel<$models.BracketExercise, $apiClients.BracketExerciseApiClient, number> implements $models.BracketExercise  {
  
  constructor(initialData?: DeepPartial<$models.BracketExercise> | null) {
    super($metadata.BracketExercise, new $apiClients.BracketExerciseApiClient(), initialData)
  }
}
defineProps(BracketExerciseViewModel, $metadata.BracketExercise)

export class BracketExerciseListViewModel extends ListViewModel<$models.BracketExercise, $apiClients.BracketExerciseApiClient, BracketExerciseViewModel> {
  
  constructor() {
    super($metadata.BracketExercise, new $apiClients.BracketExerciseApiClient())
  }
}


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
  brackets: BracketViewModel[] | null;
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


const viewModelTypeLookup = ViewModel.typeLookup = {
  Bracket: BracketViewModel,
  BracketExercise: BracketExerciseViewModel,
  Exercise: ExerciseViewModel,
  User: UserViewModel,
  Widget: WidgetViewModel,
  Workout: WorkoutViewModel,
}
const listViewModelTypeLookup = ListViewModel.typeLookup = {
  Bracket: BracketListViewModel,
  BracketExercise: BracketExerciseListViewModel,
  Exercise: ExerciseListViewModel,
  User: UserListViewModel,
  Widget: WidgetListViewModel,
  Workout: WorkoutListViewModel,
}
const serviceViewModelTypeLookup = ServiceViewModel.typeLookup = {
}

