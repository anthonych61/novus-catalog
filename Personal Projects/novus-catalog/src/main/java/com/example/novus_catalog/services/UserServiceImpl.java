package com.example.novus_catalog.services;

import com.example.novus_catalog.repository.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class UserServiceImpl implements UserService {

    @Autowired
    private UserRepository userRepository;

    public boolean isUserExistsByAccountAndPassword(String account, String password) {
        return userRepository.existsByAccountAndPassword(account, password);
    }

    public void changeUserPassword(String account, String password) {
        userRepository.update(account, password);
    }

}
