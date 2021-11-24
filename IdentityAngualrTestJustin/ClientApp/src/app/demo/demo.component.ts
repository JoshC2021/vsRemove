import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { AuthorizeService } from '../../api-authorization/authorize.service';

@Component({
    selector: 'app-demo',
    templateUrl: './demo.component.html',
    styleUrls: ['./demo.component.css']
})
/** demo component*/
export class DemoComponent {

  demoData: any = {};
  userName: string = "";
    /** demo ctor */
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private authorizedService: AuthorizeService) {
    http.get(baseUrl + 'demo').subscribe((result: any) => {
      this.demoData = result;
      console.log(result);
    });
    authorizedService.getUser().subscribe((result) => {
      this.userName = result.name;
      console.log(this.userName);
    });
  }

}
