import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CoreRoutingModule } from './core-routing.module';
import { MaterialModule } from './material/material.module';

import { AppShellComponent } from './app-shell/app-shell.component';

@NgModule({
  imports: [CommonModule, CoreRoutingModule, MaterialModule],
  declarations: [AppShellComponent],
  exports: [AppShellComponent],
})
export class CoreModule {}
