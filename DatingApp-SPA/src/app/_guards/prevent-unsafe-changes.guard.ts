import { Injectable } from "@angular/core";
import { CanDeactivate } from "@angular/router";
import { MemberEditComponent } from "../members/member-edit/member-edit.component";

@Injectable()
export class PreventUnsafeChanges implements CanDeactivate<MemberEditComponent>{
    canDeactivate(component: MemberEditComponent){
        if(component.editForm.dirty){
            return confirm('Are you sure that you want to continue? Any changes will be lost.');
        }
        return true;
    }

}