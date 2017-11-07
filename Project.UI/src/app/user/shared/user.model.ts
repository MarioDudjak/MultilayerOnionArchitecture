export class User {
    private email:string;
    private username:string;
    private password:string;
	private userID:number;

constructor(email:string,username:string,password:string){
    this.email=email;
    this.username=username;
    this.password=password;
}

public getEmail():string{
    return this.email;
}
public getUsername():string{
    return this.username;
}
public getPassword():string{
    return this.password;
}
public getId():number{
    return this.userID;
}

}