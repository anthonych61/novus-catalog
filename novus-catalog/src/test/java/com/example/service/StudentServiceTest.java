package com.example.service;


import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.mockito.Mockito.doNothing;
import static org.mockito.Mockito.times;
import static org.mockito.Mockito.verify;
import static org.mockito.Mockito.when;

import java.time.LocalDateTime;
import java.util.Arrays;
import java.util.List;
import java.util.Optional;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.mockito.ArgumentMatchers;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.MockitoAnnotations;

import com.example.novus_catalog.entities.Students;
import com.example.novus_catalog.repository.StudentRepository;
import com.example.novus_catalog.services.StudentServiceImpl;

public class StudentServiceTest {
	
	LocalDateTime createdDateTime;
	LocalDateTime modifiedDateTime;
	
	@Mock // Create a mock UserRepository
    private StudentRepository studentRepository;

    @InjectMocks // Inject the mock into LoginService
    private StudentServiceImpl studentService;
    
    @BeforeEach
    public void setup(){    	
    	createdDateTime = LocalDateTime.now();
    	modifiedDateTime = LocalDateTime.now();    	
    	MockitoAnnotations.openMocks(this);    	
    }
    
    @Test
    void testDisplayStudentRecords() {     	
        List<Students> records = Arrays.asList(
        		  new Students(1L,"Robert","Torvalds","Male","4410 Porter Street","Miami, FL","Beni","Northwestern High School","Garret","Torvalds","(704) 243-8845","03/13/2025","Frequent",createdDateTime,modifiedDateTime),
                  new Students(31L,"James","Lindsey","Male","667 Hough Circle","Rock Hill, SC","Chuquisaca","Northwestern High School","Mike","Lindsey","(121) 766-8999","04/07/2025","Occasional",createdDateTime,modifiedDateTime),
                  new Students(33L,"Maria","Brown","Female","551 Friendship Circle","Baton Rouge, LA","Potosí","Highpoint Highschool","Micheal","Brown","(566) 712-7889","04/08/2025","Frequent",createdDateTime,modifiedDateTime),
                  new Students(34L,"Mike","Greene","Male","202 Doberman Ave","New York, NY","Tarija","Geneva High School","Elizabeth","Greene","(571) 431-9887","04/23/2025","Occasional",createdDateTime,modifiedDateTime)
        );    
        when(studentRepository.findAll()).thenReturn(records);
        List<Students> retrievedRecords = studentService.getAllStudents();
        assertEquals(4, retrievedRecords.size());
        verify(studentRepository, times(1)).findAll();
    }
    
    @Test
    void testAddStudentRecord() {
        Students record = new Students(35L,"test","test","Male","test","test","test","test","test","test","(000) 000-0000","04/23/2025","Occasional",createdDateTime,modifiedDateTime);
        when(studentRepository.save(record)).thenReturn(record);

        Students savedRecord = studentService.save(record);
        assertEquals(record, savedRecord);
        verify(studentRepository, times(1)).save(record);
    }
    
    @Test
    void testEditRecord() {
        Students existingRecord =  new Students(34L,"Mike","Greene","Male","202 Doberman Ave","New York, NY","Tarija","Geneva High School","Elizabeth","Greene","(571) 431-9887","04/23/2025","Occasional",createdDateTime,modifiedDateTime);
        Students updatedRecord = new Students(34L,"John","Streitz","Male","100 Meineke Ave","New York, NY","Tarija","Edison High School","Mary","Streitz","(571) 233-9857","04/13/2025","Occasional",createdDateTime,modifiedDateTime);

        when(studentRepository.findById(34L)).thenReturn(Optional.of(existingRecord));
        when(studentRepository.save(updatedRecord)).thenReturn(updatedRecord);

        Students result = studentService.update(34L,updatedRecord); 
        
        assertThat(updatedRecord).usingRecursiveComparison().isEqualTo(result);
        verify(studentRepository, times(1)).findById(34L);
        verify(studentRepository, times(1)).save(ArgumentMatchers.refEq(updatedRecord));
    }
    
    @Test
    void testDeleteStudentRecord() {
        doNothing().when(studentRepository).deleteById(1L);
        studentService.deleteById(1L);
        verify(studentRepository, times(1)).deleteById(1L);
    }

}
