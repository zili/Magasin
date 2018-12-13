import { Component, Input } from '@angular/core';

@Component({
  selector: 'item',
  template: `<div class="row">
             <div class ="col-md-2">{{ art.code }}</div>
             <div class ="col-md-2">{{ art.libelle }}</div>
             <div class ="col-md-2">{{ art.pu }}</div>
            </div>`
})
export class ItemComponent {
  @Input() art: any;
}
