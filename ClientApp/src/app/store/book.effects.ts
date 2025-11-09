import { Actions,createEffect,ofType } from "@ngrx/effects";
import { BookService } from "../services/book.service";
import { mergeMap,map } from "rxjs/operators";
import { Action} from "@ngrx/store";
import * as types from './action.types';
import * as bookActions from './book.actions';
import { Observable } from "rxjs";


export class BookEffects {
  constructor(
    private service: BookService,
    private actions$: Actions
  ) {}

  loadBooks$ = createEffect(() =>
    this.actions$.pipe(
      ofType(types.LOAD_BOOKS),
      mergeMap(() =>
        this.service.getAllBooks().pipe(
          map(books => new bookActions.loadBooksSuccessAction(books))
        )
      )
    )
  );
}
