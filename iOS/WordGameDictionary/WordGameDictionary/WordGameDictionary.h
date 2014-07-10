//
//  WordGameDictionary.h
//  WordGameDictionary
//
//  Created by Andrew Eiche on 7/9/14.
//  Copyright (c) 2014 Birdcage Games LLC. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface WordGameDictionary : NSObject

- (instancetype)initWithDictionaryFile:(NSString*) dictionaryName;

@property (nonatomic) NSSet* wordArray;

@end
