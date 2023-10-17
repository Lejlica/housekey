export class Property {
    constructor(public id: number,
                public title: string, 
                public desc: string,
                public propertyType: string,
                public propertyStatus: string[], 
                public city: string,
                public zipCode: string[],
                public neighborhood: string[],
                public street: string[],
                public location: Location,
                public formattedAddress: string,
                public features: string[],
                public featured: boolean,
                public priceDollar: Price,
                public priceEuro: Price,
                public bedrooms: number,
                public bathrooms: number,
                public garages: number,
                public area: Area,
                public yearBuilt: number,
                public ratingsCount: number,
                public ratingsValue: number,
                public additionalFeatures: AdditionalFeature[],
                public gallery: Gallery[],
                public plans: Plan[],
                public videos: Video[],
                public published: string,
                public lastUpdate: string,
                public views: number){ }
} 


export class Area {
    constructor(public id: number, 
                public value: number,
                public unit: string){ }
}
export class NekretninaGetVM{
    constructor(
        public id:number,
        public naziv?: string,
        public cijena?: string,
        public lokacija?:string,
        public tip_akcije?:string,
        public isNovogradnja?:string,
        public isKoristeno?:string,
        public kvadratura?:number,
        public tip_nekretnine?:string,
        public broj_soba?:string,
        public opremljenost?:string,
        public sprat?:string,
        public vrsta_grijanja?:string,
        public lift?:string,
        public parking?:string,
        public garaza?:string,
        public voda?:string,
        public struja?:string,
        public kanalizacija?:string,
        public blindirana_vrata?:string,
        public klima?:string,
        public telefonski_prikljucak?:string,
        public kablovska_tv?:string,
        public internet?:string,
        public ostava_spajz?:string,
        public video_nadzor?:string,
        public alarm?:string,
        public primarna_orjentacija?:string,
        public uknjizeno_zk?:string,
        public vrsta_poda?:string,
        public nedavno_adaptiran?:string,
        public balkon?:string,
        public kvadratura_balkona?:string,
        public godina_izgradnje?:string,
        public datum_objave?:string,
        public detaljan_opis?:string,
        public slike?:SlikeGetVM[],
    ) {}
}
export class SlikeGetVM{
    constructor(
        public id:number,
        public url: string,
        public nekretninaID: number
    ) {}
}
export class AdditionalFeature {
    constructor(public id: number, 
                public name: string,
                public value: string){ }
}

export class Location {
    constructor(public propertyId: number,
                public lat: number,
                public lng: number){ }
}

export class Price {
    public sale: number;
    public rent: number;
}


export class Gallery {
    constructor(public id: number, 
                public small: string,
                public medium: string,
                public big: string){ }
}

export class Plan {
    constructor(public id: number, 
                public name: string,
                public desc: string,
                public area: Area,
                public rooms: number,
                public baths: number,
                public image: string){ }
}

export class Video {
    constructor(public id: number, 
                public name: string,
                public link: string){ }
}

export class Pagination {
    constructor(public page: number,
                public perPage: number,
                public prePage: number | null,
                public nextPage: number | null,
                public total: number,
                public totalPages: number
    ){ }
}