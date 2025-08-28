import type { Education } from '../../types';

export const educationData: Education[] = [
  {
    id: '1',
    degree: 'Master of Science in Computer Science',
    field: 'Computer Science',
    institution: 'University of Engineering',
    location: 'San Jose, CA',
    startDate: new Date('2014-09-01'),
    endDate: new Date('2016-05-01'),
    isCurrent: false,
    description: 'Focused on advanced algorithms, distributed systems, and artificial intelligence.',
    gpa: 3.8,
    achievements: ['Graduated with honors', 'Research assistant in distributed systems']
  },
  {
    id: '2',
    degree: 'Bachelor of Science in Software Engineering',
    field: 'Software Engineering',
    institution: 'State University',
    location: 'San Jose, CA',
    startDate: new Date('2010-09-01'),
    endDate: new Date('2014-05-01'),
    isCurrent: false,
    description: 'Specialized in software design patterns, database management, and web development frameworks.',
    gpa: 3.7,
    achievements: ['Dean\'s list', 'Senior project award']
  }
];
