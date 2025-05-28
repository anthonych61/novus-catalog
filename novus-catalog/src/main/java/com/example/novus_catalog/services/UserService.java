package com.example.novus_catalog.services;

import com.example.novus_catalog.entities.Users;

public interface UserService {

    public boolean isUserExistsByAccountAndPassword(String account, String password);

    public void changeUserPassword(Users user, String account, String password);

}
