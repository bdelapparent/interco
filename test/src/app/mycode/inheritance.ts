class Report {
    data: Array<string>;

    constructor(data: Array<string>) {
        this.data = data;
    }
    run() {
        this.data.forEach(function (line) { console.log(line); });
    }
}

class TabbeReport extends Report {
    headers: Array<string>;

    constructor(headers: string[], values: string[]){
        super(values);
        this.headers = headers;
    }

    run(){
        console.log(this.headers);
        super.run();
    }
}

var headers: string[] = ['Name'];
var data: string[] = ['Alice green', 'Paul Pfifer', 'Louis Blakenship'];
var r: TabbeReport = new TabbeReport(headers, data);
r.run();