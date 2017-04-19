﻿ 
import { Component } from '@angular/core';

import { jqxFormattedInputComponent } from '../../../../../jqwidgets-ts/angular_jqxformattedinput';

@Component({
    selector: 'my-app',
    template: `
        <fieldset style="width: 200px; margin-top:1em; margin-bottom: 1em; border: 1px solid lightgrey;">
            Value is {{ value | json }}
        </fieldset>

        <jqxFormattedInput [(ngModel)]='value'
            [width]='250' [height]='25' [radix]='"decimal"'
            [value]='15' [spinButtons]='true' [dropDown]='true'>
        </jqxFormattedInput>`
})

export class AppComponent
{
    value: number = 15;
}
