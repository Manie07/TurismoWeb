import { Component, OnInit, OnDestroy, Renderer2, ViewChild, ElementRef } from '@angular/core';

@Component({
  selector: 'app-inicio-turista',
  templateUrl: './inicio-turista.component.html',
  styleUrls: ['./inicio-turista.component.css'],
})
export class InicioTuristaComponent implements OnInit, OnDestroy {
  @ViewChild('carousel') carousel: ElementRef;
  imageIndex: number = 1;
  intervalId: any;

  images: { src: string }[] = [
    { src: 'https://www.triviantes.com/wp-content/uploads/2021/12/sitios-turisticos-en-cartagena-de-indias-12.jpg' },
    { src: 'https://cdn.colombia.com/images/v2/turismo/sitios-turisticos/cartagena/castillo-san-felipe-cartagena-800.jpg' },
    { src: 'https://co-nectados.procolombia.co/sites/default/files/2021-02/xPRCO_Web_Foto_Contenido_Travel_Cartagena_474247828_De_JessKraft.png.pagespeed.ic_.xv8H9NCkhj.jpg-2.png' },
    { src: 'https://rutaviajera.seguroparaviaje.com/wp-content/uploads/2022/03/Castillo-San-Felipe-de-Barajas-1024x683.jpg'}
  ];

  constructor(private renderer: Renderer2) {}

  ngOnInit() {
    this.autoSlide();
  }

  ngOnDestroy() {
    clearInterval(this.intervalId);
  }

  autoSlide() {
    this.intervalId = setInterval(() => this.slideImage(++this.imageIndex), 2000);
  }

  slideImage(index: number) {
    this.imageIndex = index === this.images.length ? 0 : index < 0 ? this.images.length - 1 : index;

    const translateValue = `translate(-${this.imageIndex * 100}%)`;
    this.renderer.setStyle(this.carousel.nativeElement, 'transform', translateValue);
  }

  updateClick(isNext: boolean) {
    clearInterval(this.intervalId);
    this.imageIndex += isNext ? 1 : -1;
    this.slideImage(this.imageIndex);
    this.autoSlide();
  }
}