import type { Skill } from '../../types';

export const technicalSkills: Skill[] = [
  {
    id: '1',
    name: 'JavaScript',
    category: { id: '1', name: 'Frontend', color: '#224A72FF' },
    proficiency: 95,
    yearsOfExperience: 5,
    description: 'Advanced JavaScript with ES6+ features'
  },
  {
    id: '2',
    name: 'TypeScript',
    category: { id: '1', name: 'Frontend', color: '#224A72FF' },
    proficiency: 80,
    yearsOfExperience: 3,
    description: 'TypeScript for type-safe development'
  }
];
