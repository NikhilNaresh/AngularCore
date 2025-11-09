
import { Action } from '@ngrx/store';
import * as bookActions from './book.actions';
import * as types from './action.types';
import { AppState } from './app.state';

export const initialState : AppState = 
{
    books:[]
}


// Your reducer should accept every Action
export function BookReducer(state = initialState, action: Action): AppState {
    switch(action.type) {
        case types.LOAD_BOOKS_SUCCESS:
            // Safely cast action to your expected type for this case
            return { ...state, books: (action as bookActions.loadBooksSuccessAction).payload };
        default:
            return state;
    }
}
