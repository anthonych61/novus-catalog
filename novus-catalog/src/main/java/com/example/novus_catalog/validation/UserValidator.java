package com.example.novus_catalog.validation;

import com.example.novus_catalog.entities.Students;
import com.example.novus_catalog.entities.Users;
import com.example.novus_catalog.services.UserServiceImpl;

import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpSession;
import jakarta.validation.Valid;
import org.springframework.web.bind.annotation.ModelAttribute;

import java.util.ArrayList;
import java.util.List;

public class UserValidator {

    private List<String> allErrors = new ArrayList<>();

    public UserValidator() {}

    public List<String> validateRegistration(@Valid @ModelAttribute("formData") Students formData) {

        if (formData.getFirstName().trim().isEmpty()) { // validate firstname field
            allErrors.add("Firstname must have a value.");
        }

        if (formData.getLastName().trim().isEmpty()) { // validate lastname field
            allErrors.add("Lastname must have a value.");
        }

        if (formData.getGender().trim().isEmpty()) { // validate gender field
            allErrors.add("Please select your gender.");
        }

        if (formData.getDateEnrolled().trim().isEmpty()) { // validate date enrolled field
            allErrors.add("Please select your date.");
        }

        if (formData.getAttendance().trim().isEmpty()) { // validate attendance field
            allErrors.add("Attendance must have a value.");
        }
        return allErrors;
    }

    public List<String> validatePasswordChange(@Valid @ModelAttribute("formData") Users formData, UserServiceImpl userService) {

        boolean isValidAdminPassword = userService.isUserExistsByAccountAndPassword("Administrator", formData.getOldAdminPassword());
        boolean isValidMentorPassword = userService.isUserExistsByAccountAndPassword("Mentor", formData.getOldMentorPassword());

        if(!formData.getOldAdminPassword().trim().isEmpty() && !isValidAdminPassword) {
            allErrors.add("Admin password not valid.");
        }
        if(!formData.getOldMentorPassword().trim().isEmpty() && !isValidMentorPassword) {
            allErrors.add("Mentor password not valid.");
        }
        if (formData.getOldMentorPassword().trim().isEmpty() && !formData.getNewMentorPassword().trim().isEmpty()) {
            allErrors.add("Existing Mentor password must have a value.");
        }
        if (formData.getOldAdminPassword().trim().isEmpty() && !formData.getNewAdminPassword().trim().isEmpty()) {
            allErrors.add("Existing Admin password must have a value.");
        }
        return allErrors;
    }
}
