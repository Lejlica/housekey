import { Component, OnInit, ViewChild, HostListener, ViewChildren, QueryList } from '@angular/core';
import {FormBuilder, FormGroup, UntypedFormBuilder, UntypedFormGroup, Validators} from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { AppService } from 'src/app/app.service';
import {NekretninaGetVM, Property, SlikeGetVM} from 'src/app/app.models';
import { SwiperConfigInterface, SwiperDirective } from 'ngx-swiper-wrapper';
import { AppSettings, Settings } from 'src/app/app.settings';
import { CompareOverviewComponent } from 'src/app/shared/compare-overview/compare-overview.component';
import { emailValidator } from 'src/app/theme/utils/app-validators';
import { EmbedVideoService } from 'src/app/services/embed-video.service';
import emailjs from '@emailjs/browser';

@Component({
  selector: 'app-property',
  templateUrl: './property.component.html',
  styleUrls: ['./property.component.scss'],
  providers: [EmbedVideoService]
})
export class PropertyComponent implements OnInit {
  @ViewChild('sidenav') sidenav: any;  
  @ViewChildren(SwiperDirective) swipers: QueryList<SwiperDirective>;
  public sidenavOpen:boolean = true;
  public config: SwiperConfigInterface = {}; 
  public config2: SwiperConfigInterface = {}; 
  private sub: any;
  public property:NekretninaGetVM;
  public settings: Settings;  
  public embedVideo: any;
  public relatedProperties: Property[];
  public featuredProperties: NekretninaGetVM[];
  public ftr:NekretninaGetVM;
  public agent:any;
  public mortgageForm: UntypedFormGroup;
  public monthlyPayment:any;
 // public contactForm: UntypedFormGroup;
  mapOptions: google.maps.MapOptions = { 
    mapTypeControl: true,
    fullscreenControl: true
  }
  lat: number = 0;
  lng: number = 0;



  constructor(public appSettings:AppSettings, 
              public appService:AppService, 
              private activatedRoute: ActivatedRoute, 
              private embedService: EmbedVideoService,
              public fb: FormBuilder) {
    this.settings = this.appSettings.settings; 
  }
  contactForm : FormGroup =this.fb.group({
    name: ['', Validators.required],
    email: ['', Validators.compose([Validators.required, emailValidator])],
    phone: ['', Validators.required],
    message: ['', Validators.required]
  });

   send() {
    emailjs.init('ssNuuWtWmh_F2MHZy')
    emailjs.send("service_efhufis", "template_zlefg6k", {
      from_name: this.contactForm.value.name,
      to_name: "Admin",
      from_email: this.contactForm.value.email,
      phone: this.contactForm.value.phone,
      message: this.contactForm.value.message,
    });

    alert('Mail je poslan');
  }

  ngOnInit() {
   this.sub = this.activatedRoute.params.subscribe(params => {
      this.getPropertyById(params['id']); 
    });
    this.getRelatedProperties();
    this.getFeaturedProperties();
    console.log(this.featuredProperties);
    this.getAgent(1);
    if(window.innerWidth < 960){
      this.sidenavOpen = false;
      if(this.sidenav){
        this.sidenav.close();
      } 
    };
    this.mortgageForm = this.fb.group({
      principalAmount: ['', Validators.required],
      downPayment: ['', Validators.required], 
      interestRate: ['', Validators.required],
      period: ['', Validators.required]
    });

  } 

  ngOnDestroy() {
    this.sub.unsubscribe();
  }  

  @HostListener('window:resize')
  public onWindowResize():void {
    (window.innerWidth < 960) ? this.sidenavOpen = false : this.sidenavOpen = true; 
  }

  public getPropertyById(id: number){
    this.appService.getPropertyById(id).subscribe(data=>{
      this.property = data;  
      //this.embedVideo = this.embedService.embed(this.property.videos[1].link);
      //this.lat = +this.property.lokacija.lat;
      //this.lng = +this.property?.location.lng;
      setTimeout(() => { 
        this.config.observer = true;
        this.config2.observer = true; 
        this.swipers.forEach(swiper => { 
          if(swiper){
            swiper.setIndex(0);
          } 
        }); 
      });
    });
  }

  ngAfterViewInit(){
    this.config = {
      observer: false,
      slidesPerView: 1,
      spaceBetween: 0,       
      keyboard: true,
      navigation: true,
      pagination: false,
      grabCursor: true,        
      loop: false,
      preloadImages: false,
      lazy: true,
      autoplay: {
        delay: 5000,
        disableOnInteraction: false
      }
    };

    this.config2 = {
      observer: false,
      slidesPerView: 4,
      spaceBetween: 16,      
      keyboard: true,
      navigation: false,
      pagination: false, 
      grabCursor: true,       
      loop: false, 
      preloadImages: false,
      lazy: true,  
      breakpoints: {
        200: {
          slidesPerView: 2
        },
        480: {
          slidesPerView: 3
        },
        600: {
          slidesPerView: 4
        } 
      }
    } 

  }
  

  public onOpenedChange(){ 
    this.swipers.forEach(swiper => { 
      if(swiper){
        swiper.update();
      } 
    });     
  }

  public selectImage(index:number){ 
    this.swipers.forEach(swiper => {
      if(swiper['elementRef'].nativeElement.id == 'main-carousel'){
        swiper.setIndex(index);
      }      
    }); 
  }

  public onIndexChange(index: number) {  
    this.swipers.forEach(swiper => { 
      let elem = swiper['elementRef'].nativeElement;
      if(elem.id == 'small-carousel'){
        swiper.setIndex(index);  
        for (let i = 0; i < elem.children[0].children.length; i++) {
          const element = elem.children[0].children[i]; 
          if(element.classList.contains('thumb-'+index)){
            element.classList.add('active-thumb'); 
          }
          else{
            element.classList.remove('active-thumb'); 
          }
        }
      } 
    });     
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

  public getRelatedProperties(){
    this.appService.getRelatedProperties().subscribe(properties=>{
      this.relatedProperties = properties;
    })
  }

  public getFeaturedProperties(){
    /*this.appService.getFeaturedProperties().subscribe(properties=>{
      this.featuredProperties = properties.slice(0,3); 
    })*/
    this.appService.getFeaturedProperties().subscribe(properties => {
      this.featuredProperties = properties.filter(property => {
        return (
            property.tip_akcije !== undefined &&
            property.cijena !== undefined &&
            property.kvadratura !== undefined &&
            property.isKoristeno !== undefined &&
            property.isNovogradnja !== undefined &&
            property.lokacija !== undefined &&
            property.tip_nekretnine !== undefined


            // Dodajte ostala svojstva ovdje...
        );
      }).slice(0, 3);
    });
  } 

  public getAgent(agentId:number = 1){
    var ids = [1,2,3,4,5]; //agent ids 
    agentId = ids[Math.floor(Math.random()*ids.length)]; //random agent id
    this.agent = this.appService.getAgents().filter(agent=> agent.id == agentId)[0]; 
  }

 // public onContactFormSubmit(values:Object){
 //   if (this.contactForm.valid) {
 //     console.log(values);
 //   }
 // }

  public onMortgageFormSubmit(values:Object){ 
    if (this.mortgageForm.valid) { 
      var principalAmount = values['principalAmount']
      var down = values['downPayment']
      var interest = values['interestRate']
      var term = values['period']
      this.monthlyPayment = this.calculateMortgage(principalAmount, down, interest / 100 / 12, term * 12).toFixed(2);
    }     
  }
  public calculateMortgage(principalAmount:any, downPayment:any, interestRate:any, period:any){    
    return ((principalAmount-downPayment) * interestRate) / (1 - Math.pow(1 + interestRate, -period));
  } 

}