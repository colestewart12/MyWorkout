import * as $metadata from './metadata.g'
import * as $models from './models.g'
import { ModelApiClient, ServiceApiClient, ItemResult, ListResult } from 'coalesce-vue/lib/api-client'

export class BracketApiClient extends ModelApiClient<$models.Bracket> {
  constructor() { super($metadata.Bracket) }
}


export class BracketExerciseApiClient extends ModelApiClient<$models.BracketExercise> {
  constructor() { super($metadata.BracketExercise) }
}


export class ExerciseApiClient extends ModelApiClient<$models.Exercise> {
  constructor() { super($metadata.Exercise) }
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


