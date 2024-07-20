import * as metadata from './metadata.g'
import { Model, DataSource, convertToModel, mapToModel } from 'coalesce-vue/lib/model'

export enum WidgetCategory {
  Whizbangs = 0,
  Sprecklesprockets = 1,
  Discombobulators = 2,
}


export interface Bracket extends Model<typeof metadata.Bracket> {
  bracketId: number | null
  bracketName: string | null
  workoutId: number | null
  exercises: BracketExercise[] | null
}
export class Bracket {
  
  /** Mutates the input object and its descendents into a valid Bracket implementation. */
  static convert(data?: Partial<Bracket>): Bracket {
    return convertToModel(data || {}, metadata.Bracket) 
  }
  
  /** Maps the input object and its descendents to a new, valid Bracket implementation. */
  static map(data?: Partial<Bracket>): Bracket {
    return mapToModel(data || {}, metadata.Bracket) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Bracket; }
  
  /** Instantiate a new Bracket, optionally basing it on the given data. */
  constructor(data?: Partial<Bracket> | {[k: string]: any}) {
    Object.assign(this, Bracket.map(data || {}));
  }
}


export interface BracketExercise extends Model<typeof metadata.BracketExercise> {
  bracketExerciseId: number | null
  exerciseId: number | null
  bracketId: number | null
  weight: number | null
}
export class BracketExercise {
  
  /** Mutates the input object and its descendents into a valid BracketExercise implementation. */
  static convert(data?: Partial<BracketExercise>): BracketExercise {
    return convertToModel(data || {}, metadata.BracketExercise) 
  }
  
  /** Maps the input object and its descendents to a new, valid BracketExercise implementation. */
  static map(data?: Partial<BracketExercise>): BracketExercise {
    return mapToModel(data || {}, metadata.BracketExercise) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.BracketExercise; }
  
  /** Instantiate a new BracketExercise, optionally basing it on the given data. */
  constructor(data?: Partial<BracketExercise> | {[k: string]: any}) {
    Object.assign(this, BracketExercise.map(data || {}));
  }
}


export interface Exercise extends Model<typeof metadata.Exercise> {
  exerciseId: number | null
  name: string | null
  description: string | null
  difficulty: number | null
}
export class Exercise {
  
  /** Mutates the input object and its descendents into a valid Exercise implementation. */
  static convert(data?: Partial<Exercise>): Exercise {
    return convertToModel(data || {}, metadata.Exercise) 
  }
  
  /** Maps the input object and its descendents to a new, valid Exercise implementation. */
  static map(data?: Partial<Exercise>): Exercise {
    return mapToModel(data || {}, metadata.Exercise) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Exercise; }
  
  /** Instantiate a new Exercise, optionally basing it on the given data. */
  constructor(data?: Partial<Exercise> | {[k: string]: any}) {
    Object.assign(this, Exercise.map(data || {}));
  }
}


export interface User extends Model<typeof metadata.User> {
  userId: number | null
  name: string | null
  birthDate: Date | null
}
export class User {
  
  /** Mutates the input object and its descendents into a valid User implementation. */
  static convert(data?: Partial<User>): User {
    return convertToModel(data || {}, metadata.User) 
  }
  
  /** Maps the input object and its descendents to a new, valid User implementation. */
  static map(data?: Partial<User>): User {
    return mapToModel(data || {}, metadata.User) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.User; }
  
  /** Instantiate a new User, optionally basing it on the given data. */
  constructor(data?: Partial<User> | {[k: string]: any}) {
    Object.assign(this, User.map(data || {}));
  }
}


export interface Widget extends Model<typeof metadata.Widget> {
  widgetId: number | null
  name: string | null
  category: WidgetCategory | null
  inventedOn: Date | null
}
export class Widget {
  
  /** Mutates the input object and its descendents into a valid Widget implementation. */
  static convert(data?: Partial<Widget>): Widget {
    return convertToModel(data || {}, metadata.Widget) 
  }
  
  /** Maps the input object and its descendents to a new, valid Widget implementation. */
  static map(data?: Partial<Widget>): Widget {
    return mapToModel(data || {}, metadata.Widget) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Widget; }
  
  /** Instantiate a new Widget, optionally basing it on the given data. */
  constructor(data?: Partial<Widget> | {[k: string]: any}) {
    Object.assign(this, Widget.map(data || {}));
  }
}


export interface Workout extends Model<typeof metadata.Workout> {
  workoutId: number | null
  title: string | null
  description: string | null
  brackets: Bracket[] | null
}
export class Workout {
  
  /** Mutates the input object and its descendents into a valid Workout implementation. */
  static convert(data?: Partial<Workout>): Workout {
    return convertToModel(data || {}, metadata.Workout) 
  }
  
  /** Maps the input object and its descendents to a new, valid Workout implementation. */
  static map(data?: Partial<Workout>): Workout {
    return mapToModel(data || {}, metadata.Workout) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Workout; }
  
  /** Instantiate a new Workout, optionally basing it on the given data. */
  constructor(data?: Partial<Workout> | {[k: string]: any}) {
    Object.assign(this, Workout.map(data || {}));
  }
}


