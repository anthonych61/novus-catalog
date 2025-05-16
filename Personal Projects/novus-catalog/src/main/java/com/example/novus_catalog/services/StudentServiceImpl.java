package com.example.novus_catalog.services;

import com.example.novus_catalog.entities.Students;
import com.example.novus_catalog.repository.StudentRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;
import java.util.Optional;

@Service
public class StudentServiceImpl implements StudentService {

    @Autowired
    private StudentRepository studentRepository;

    public List<Students> getAllStudents() {
        return studentRepository.findAll();
    }

    public Students save(Students student) { return studentRepository.save(student); }

    public Optional<Students>findById(Long id) { return studentRepository.findById(id); }

    public List<Students> findAllById(List <Long> id) { return studentRepository.findAllById(id); }

    public Students update(Long id, Students updateStudent) {
        return studentRepository.findById(id)
                .map(student -> {
                    student.setFirstName(updateStudent.getFirstName());
                    student.setLastName(updateStudent.getLastName());
                    student.setGender(updateStudent.getGender());
                    student.setAddress(updateStudent.getAddress());
                    student.setCity(updateStudent.getCity());
                    student.setDepartment(updateStudent.getDepartment());
                    student.setSchool(updateStudent.getSchool());
                    student.setParentFirstName(updateStudent.getParentFirstName());
                    student.setParentLastName(updateStudent.getParentLastName());
                    student.setPhoneNumber(updateStudent.getPhoneNumber());
                    student.setDateEnrolled(updateStudent.getDateEnrolled());
                    student.setAttendance(updateStudent.getAttendance());
                    student.setModifiedDateTime(updateStudent.getModifiedDateTime());
                    return studentRepository.save(student);
                })
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "User not found with id: " + id));

    }

    public void deleteById(Long id) { studentRepository.deleteById(id); }

    public void deleteAllById(List <Long> id) { studentRepository.deleteAllById(id); }

}
