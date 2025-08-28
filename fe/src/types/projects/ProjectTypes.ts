import type { BaseEntity } from '../common/BaseTypes';

export interface Project extends BaseEntity {
  title: string;
  description: string;
  image: string;
  technologies: string[];
  githubUrl?: string;
  liveUrl?: string;
  features: string[];
  isFeatured: boolean;
  category: ProjectCategory;
}

export type ProjectCategory = 'Web App' | 'Mobile App' | 'Desktop App' | 'API' | 'Library' | 'Other';
