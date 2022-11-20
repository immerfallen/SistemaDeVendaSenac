import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UsuarioEditarRoutingModule } from './usuario-editar-routing.module';
import { UsuarioEditarComponent } from './usuario-editar.component';

@NgModule({
  declarations: [UsuarioEditarComponent],
  imports: [
    CommonModule,
    UsuarioEditarRoutingModule
  ]
})
export class UsuarioEditarModule { }
