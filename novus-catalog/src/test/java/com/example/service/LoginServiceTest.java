package com.example.service;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;
import static org.mockito.ArgumentMatchers.any;
import static org.mockito.Mockito.never;
import static org.mockito.Mockito.times;
import static org.mockito.Mockito.verify;
import static org.mockito.Mockito.when;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.junit.jupiter.MockitoExtension;

import com.example.novus_catalog.entities.Users;
import com.example.novus_catalog.repository.UserRepository;
import com.example.novus_catalog.services.UserServiceImpl;

@ExtendWith(MockitoExtension.class) 
public class LoginServiceTest {
	
	@Mock // create a mock UserRepository
    private UserRepository userRepository;

    @InjectMocks // inject the mock into LoginService
    private UserServiceImpl userService;

    private Users user;

    @BeforeEach
    public void setup() {
        user = new Users("Administrator", "admin");
    }
    
    @Test
    public void testLoginSuccess() {
        // Arrange: Define the behavior of the mocked UserRepository/ Setup the test environment
        when(userRepository.existsByAccountAndPassword("Administrator","admin")).thenReturn(true);
        
        // Act: Perform the login attempt
        boolean loginResult = userService.isUserExistsByAccountAndPassword("Administrator", "admin");
        
        // Assert: Verify the expected outcome
        assertTrue(loginResult, "Login should be successful with valid credentials.");
    }
    
    @Test
    public void testLoginFailure_invalidCredentials() {
    	
    	when(userRepository.existsByAccountAndPassword("Administrator","test1234")).thenReturn(false);

        // attempt login with incorrect password
        boolean loginResult = userService.isUserExistsByAccountAndPassword("Administrator", "test1234");

        assertFalse(loginResult, "Login should fail with invalid credentials.");
    }
    
    @Test
    public void changePassword_validUserAndPassword_passwordChanged() {
    	
        String username = "Administrator";	
        String oldPassword = "admin";
        String newPassword = "password123";
        
        // mock the user repository to return the user
        userRepository.findByAccount(username);

        // mock the user repository to save the updated user (if needed)
        userRepository.save(user);

        // Act: Perform the password change
        userService.changeUserPassword(user, username, newPassword);
       
        // Assert: Verify that the password was changed 
        verify(userRepository, times(1)).findByAccount(username);
        verify(userRepository, times(1)).save(user); 
               
        // verify that the user object's password was updated
        assertEquals(newPassword, user.getPassword());   	      
    }
    
  
}
