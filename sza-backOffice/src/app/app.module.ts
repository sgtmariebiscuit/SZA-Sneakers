import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './screens/login/login.component';
import { DashboardComponent } from './screens/dashboard/dashboard.component';
import { NavigationBarComponent } from './components/navigation-bar/navigation-bar.component';
import { FooterComponent } from './components/footer/footer.component';
import { SneakerComponent } from './screens/sneaker/sneaker.component';
import { AddSneakerComponent } from './components/Sneaker/add-sneaker/add-sneaker.component';
import { UpdateSneakerComponent } from './components/Sneaker/update-sneaker/update-sneaker.component';
import { AllSneakerComponent } from './components/Sneaker/all-sneaker/all-sneaker.component';
import { UserManagementComponent } from './screens/user-management/user-management.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    DashboardComponent,
    NavigationBarComponent,
    FooterComponent,
    SneakerComponent,
    AddSneakerComponent,
    UpdateSneakerComponent,
    AllSneakerComponent,
    UserManagementComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
