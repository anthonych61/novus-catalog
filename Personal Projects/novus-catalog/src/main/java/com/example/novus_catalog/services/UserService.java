package com.example.novus_catalog.services;

public interface UserService {

    public boolean isUserExistsByAccountAndPassword(String account, String password);

    public void changeUserPassword(String account, String password);

}
