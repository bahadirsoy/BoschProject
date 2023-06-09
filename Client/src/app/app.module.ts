//modules
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

//angular material modules
import {MatCardModule} from '@angular/material/card';
import {MatInputModule} from '@angular/material/input';
import {MatSliderModule} from '@angular/material/slider';

//angular bootstrap modules
import { NgbAlertModule, NgbNav } from '@ng-bootstrap/ng-bootstrap';
import { NgbModule, NgbTooltip } from '@ng-bootstrap/ng-bootstrap';

//components
import { AppComponent } from './app.component';
import { HomepageComponent } from './components/homepage/homepage.component';
import { HeaderComponent } from './components/header/header.component';
import { CreateSiparisComponent } from './components/create-siparis/create-siparis.component';
import { ManufactureComponent } from './components/manufacture/manufacture.component';
import { ProductionComponent } from './components/production/production.component';
import { IstasyonComponent } from './components/istasyon/istasyon.component';

const appRoutes: Routes = [
  {path: '', component: HomepageComponent},
  {path: 'createSiparis', component: CreateSiparisComponent},
  {path: 'manufacture', component: ManufactureComponent},
  {path: 'manufacture/:id', component: ProductionComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    HomepageComponent,
    HeaderComponent,
    CreateSiparisComponent,
    ManufactureComponent,
    ProductionComponent,
    IstasyonComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    NgbModule,
    BrowserAnimationsModule,
    MatCardModule,
    NgbAlertModule,
    MatInputModule,
    MatSliderModule,
    RouterModule.forRoot(appRoutes, {enableTracing: false}),
    FormsModule,
    FontAwesomeModule,
    NgbTooltip
  ],
  exports: [RouterModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
