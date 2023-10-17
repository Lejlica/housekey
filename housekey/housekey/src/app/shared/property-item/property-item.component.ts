import { Component, OnInit, Input, ViewChild, SimpleChange } from '@angular/core';
import { SwiperDirective, SwiperConfigInterface, SwiperPaginationInterface } from 'ngx-swiper-wrapper';
import {NekretninaGetVM, Property, SlikeGetVM} from '../../app.models';
import { Settings, AppSettings } from '../../app.settings';
import SwiperCore, { Pagination, Navigation } from 'swiper';
import { AppService } from '../../app.service';
import { CompareOverviewComponent } from '../compare-overview/compare-overview.component';
import {environment} from "../../../environments/environment";
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {Observable} from "rxjs";

@Component({
  selector: 'app-property-item',
  templateUrl: './property-item.component.html',
  styleUrls: ['./property-item.component.scss'] 
})
export class PropertyItemComponent implements OnInit {
  @Input() property: NekretninaGetVM;
  @Input() properties:NekretninaGetVM[]=[];
  @Input() slika: SlikeGetVM;
  @Input() viewType: string = "grid";
  @Input() viewColChanged: boolean = false; 
  @Input() fullWidthPage: boolean = true;   
  public column:number = 4;
  public slikePodaci:any;
  // public address:string; 
  @ViewChild(SwiperDirective) directiveRef: SwiperDirective;
  public config: SwiperConfigInterface = {};
  private pagination: SwiperPaginationInterface = {
    el: '.swiper-pagination',
    clickable: true
  };
  public slike$: Observable<SlikeGetVM[]>;
  public settings: Settings;
  constructor(public appSettings:AppSettings, public appService:AppService,public http:HttpClient) {
    this.settings = this.appSettings.settings;
  }

  ngOnInit() {

  }

  ngAfterViewInit(){
    this.initCarousel();
    // this.appService.getAddress(this.property.location.lat, this.property.location.lng).subscribe(data=>{
    //   console.log(data['results'][0]['formatted_address']);
    //   this.address = data['results'][0]['formatted_address'];
    // })
  } 
 //nije cijena zbog buggova promijenila
  ngOnChanges(changes: {[propKey: string]: SimpleChange}){
    if(changes.viewColChanged){
      this.getColumnCount(changes.viewColChanged.currentValue);
      if(!changes.viewColChanged.isFirstChange()){
        if(this.property.cijena !==null){
           this.directiveRef.update();
        }
      }
    }

    for (let propName in changes) {      
      // let changedProp = changes[propName];
      // if (!changedProp.isFirstChange()) {
      //   if(this.property.gallery.length > 1){
      //     this.initCarousel();
      //     this.config.autoHeight = true;       
      //     this.directiveRef.update();  
      //   }       
      // }      
    }  
  }

  public getColumnCount(value){
    if(value == 25){
      this.column = 4;
    }
    else if(value == 33.3){
      this.column = 3;
    }
    else if(value == 50){
      this.column = 2
    }
    else{
      this.column = 1;
    }
  }

  public getStatusBgColor(status){
    switch (status) {
      case 'Prodaja':
        return '#558B2F';  
      case 'nn':
        return '#1E88E5'; 
      case 'Open House':
        return '#009688';
      case 'Iznajmljivanje':
        return '#FFA000';
      case 'Novogradnja':
        return '#F44336';
      case 'Sold':
        return '#000';
      default:
        return null;

    }
  }


  public initCarousel(){
    this.config = {
      slidesPerView: 1,
      spaceBetween: 0,         
      keyboard: false,
      navigation: true,
      pagination: this.pagination,
      grabCursor: true,        
      loop: true,
      preloadImages: false,
      lazy: true,  
      nested: true,
      // autoplay: {
      //   delay: 5000,
      //   disableOnInteraction: false
      // },
      speed: 500,
      effect: "slide"
    }
  }
  

  public addToCompare(){
    this.appService.addToCompare(this.property, CompareOverviewComponent, (this.settings.rtl) ? 'rtl':'ltr'); 
  }

  public onCompare(){
    return this.appService.Data.compareList.filter(item=>item.id == this.property.id)[0];
  }

  public addToFavorites(){
    this.appService.addToFavorites(this.property, (this.settings.rtl) ? 'rtl':'ltr');
  }

  public onFavorites(){
    return this.appService.Data.favorites.filter(item=>item.id == this.property.id)[0];
  }
  public getSlike(n: NekretninaGetVM): Observable<SlikeGetVM[]> {
    return this.appService.getSlike(n.id);
  }
  public nekretninePodaci:any;


}
