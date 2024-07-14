import * as $metadata from './metadata.g'
import * as $models from './models.g'
import { AxiosPromise, AxiosRequestConfig, ModelApiClient, ServiceApiClient, ItemResult, ListResult } from 'coalesce-vue/lib/api-client'

export class ExerciseApiClient extends ModelApiClient<$models.Exercise> {
  constructor() { super($metadata.Exercise) }
}


export class SetExerciseApiClient extends ModelApiClient<$models.SetExercise> {
  constructor() { super($metadata.SetExercise) }
}


export class UserApiClient extends ModelApiClient<$models.User> {
  constructor() { super($metadata.User) }
}


export class WidgetApiClient extends ModelApiClient<$models.Widget> {
  constructor() { super($metadata.Widget) }
}


export class WorkoutApiClient extends ModelApiClient<$models.Workout> {
  constructor() { super($metadata.Workout) }
}


export class WorkoutSetApiClient extends ModelApiClient<$models.WorkoutSet> {
  constructor() { super($metadata.WorkoutSet) }
}


