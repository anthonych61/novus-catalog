package com.example.novus_catalog.services;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.novus_catalog.entities.Users;
import com.example.novus_catalog.repository.UserRepository;

@Service
public class UserServiceImpl implements UserService {

    @Autowired
    private UserRepository userRepository;
        
    public boolean isUserExistsByAccountAndPassword(String account, String password) {     	
    	return userRepository.existsByAccountAndPassword(account, password);   
    }

    public void changeUserPassword(Users user, String account, String password) {
    	if(account == null && password == null) {
	    	throw new IllegalArgumentException("Empty Password");
    	}
    	user.setPassword(password);
	    userRepository.update(account, password);
    	
    }

}
