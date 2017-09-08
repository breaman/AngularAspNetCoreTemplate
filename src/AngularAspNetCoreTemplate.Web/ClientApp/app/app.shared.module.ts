import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, UrlSerializer } from '@angular/router';

import { appRoutes } from "./_routes/routes";
import { LowerCaseUrlSerializer } from "./_providers/lower-case-url-serializer";

import { AppComponent } from './_components/app/app.component';
import { NavBarComponent } from './_components/nav-bar/nav-bar.component';
import { HomeComponent } from './_components/home/home.component';
import { Error404Component } from './_components/error404/error404.component';

@NgModule({
    declarations: [
        AppComponent,
        NavBarComponent,
        HomeComponent,
        Error404Component
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot(appRoutes)
    ],
    providers: [
        {provide: UrlSerializer, useClass: LowerCaseUrlSerializer}
    ]
})
export class AppModuleShared {
}