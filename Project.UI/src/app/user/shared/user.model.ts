export class User {
    private Email:string;
    private Username:string;
    private Password:string;
	private UserID:number;

constructor(email:string,username:string,password:string){
    this.Email=email;
    this.Username=username;
    this.Password=password;
}

public getEmail():string{
    return this.Email;
}
public getUsername():string{
    return this.Username;
}
public getPassword():string{
    return this.Password;
}
public getId():number{
    return this.UserID;
}

}