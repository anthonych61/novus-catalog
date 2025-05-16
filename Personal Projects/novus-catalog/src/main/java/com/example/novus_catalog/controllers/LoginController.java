package com.example.novus_catalog.controllers;

import com.example.novus_catalog.entities.Users;
import com.example.novus_catalog.helpers.DropDownList;
import com.example.novus_catalog.services.UserServiceImpl;
import jakarta.servlet.http.HttpSession;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

@Controller
public class LoginController {

    @Autowired
    private UserServiceImpl userService;

    @GetMapping("/")
    public String userLogin(Model model) {
        DropDownList userSelection = new DropDownList();
        model.addAttribute("formData", new Users());
        userSelection.setDropDownList("--Please select--");
        model.addAttribute("selectedValue", userSelection);
        model.addAttribute("accounts", DropDownList.accounts);
        return "login";
    }

    @PostMapping("/login")
    public String submitLogin(HttpSession session, @RequestParam("account") String account, @RequestParam("password") String password,
                              @ModelAttribute("formData") Users formData,
                              Model model) {
        account = account.trim();
        password = password.trim();
        session.setAttribute("account", account);
        boolean isAuthenticated = userService.isUserExistsByAccountAndPassword(account, password);

        if (isAuthenticated) {
            // authentication successful
            return "redirect:/default";

        } else {
            DropDownList userSelection = new DropDownList();
            model.addAttribute("selectedValue", userSelection);
            model.addAttribute("accounts", DropDownList.accounts);

            // authentication failed
            model.addAttribute("allErrors", "The password you entered could not be found. Please try again.");
            return "login";
        }

    }

}