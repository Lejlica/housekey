import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-monthly',
  templateUrl: './monthly.component.html' 
})
export class MonthlyComponent implements OnInit {
  public items = [
    //{ name: 'free', price: 0, desc: 'Simplest package to get you started', properties: '10', agentProfiles: '1', agencyProfiles: '0', featuredProperties: '0' },
    { name: 'obični paket', price: 10, nekretnina: '1', slike: '1-5'},
    { name: 'premium paket', price: 20, nekretnina: '1', slike: '5-10' },
    //{ name: 'professional', price: 159, desc: 'Our most advanced & complete package', properties: 'Unlimited', agentProfiles: 'Unlimited', agencyProfiles: 'Unlimited', featuredProperties: 'Unlimited' }
  ]

  constructor() { }

  ngOnInit() {
  }

}
