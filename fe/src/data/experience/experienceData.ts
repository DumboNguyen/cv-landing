import type { Experience } from '../../types';

export const experienceData: Experience[] = [
  {
    id: '1',
    title: 'Senior Software Engineer',
    company: 'Tech Innovations Inc.',
    location: 'New York, NY',
    startDate: new Date('2021-01-01'),
    isCurrent: true,
    description: 'Led the development of a real-time data streaming platform, reducing data latency by 40% and improving analytics capabilities.',
    achievements: [
      'Led the development of a real-time data streaming platform, reducing data latency by 40% and improving analytics capabilities.',
      'Designed and implemented a microservices architecture for user authentication, enhancing security and system scalability.',
      'Mentored junior engineers, fostering a collaborative environment and improving code quality across the team.'
    ],
    technologies: ['React', 'Node.js', 'MongoDB', 'Redis', 'AWS']
  },
  {
    id: '2',
    title: 'Software Engineer',
    company: 'Data Solutions Corp.',
    location: 'San Francisco, CA',
    startDate: new Date('2018-08-01'),
    endDate: new Date('2020-12-31'),
    isCurrent: false,
    description: 'Developed and maintained RESTful APIs for customer-facing applications, serving over 100,000 daily users.',
    achievements: [
      'Developed and maintained RESTful APIs for customer-facing applications, serving over 100,000 daily users.',
      'Contributed to the migration of legacy systems to modern cloud infrastructure (AWS), resulting in a 25% cost reduction.',
      'Implemented automated testing procedures, leading to a 15% decrease in reported bugs post-deployment.'
    ],
    technologies: ['Java', 'Spring Boot', 'PostgreSQL', 'Docker', 'Jenkins']
  }
];
